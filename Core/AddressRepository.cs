using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class AddressRepository
    {
        private int previousAddressCount = DataStore.AddressTbl.Count;

        public string AddAdress(Address model, string email)
        {
            string message = string.Empty;
            User userToUpdate = null;

            if(model != null)
            {
                foreach (var user in DataStore.UserTbl)
                {
                    if(user.Email == email)
                        userToUpdate.Address.UserId = model.UserId;
                        userToUpdate.Address.StreetName = model.StreetName;
                        userToUpdate.Address.State = model.State;
                        userToUpdate.Address.Town = model.Town;
                        userToUpdate.Address.country = model.country;
                    break;
                }

                DataStore.AddressTbl.Add(model);

                int updatedAddressCount = DataStore.AddressTbl.Count;

                if(updatedAddressCount > previousAddressCount)
                    message = "Address addedd successfully";
            }
            else
            {
                message = "ooops... something went wrong";
            }

            return message;
        }

        public Address GetUerAddress(int id)
        {
            Address addressToreturn = null;

            foreach (var address in DataStore.AddressTbl)
            {
                if (address.UserId == id)
                {
                    addressToreturn.State = address.State;
                    addressToreturn.StreetName = address.StreetName;
                    addressToreturn.Town = address.Town;
                    addressToreturn.country = address.country;
                }
                    
            }
            return addressToreturn;
        }

    }
}
