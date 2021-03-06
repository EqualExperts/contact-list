﻿using System.Collections.Generic;

namespace ContactList.Models {

    public interface IContactRepository {

        IList<Contact> GetContacts(string searchText = null);

        CreateCodesEnum SaveContact(Contact contact);

        bool DeleteContact(Contact contact);

        bool DeleteAll();

        bool UpdateContact(Contact contact);
    }
}