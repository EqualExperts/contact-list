﻿using ContactList.Models;
using ContactList.ViewModels;
using Xunit;

namespace ContactListUnitTest.ViewModels {

    public class CreateContactViewModelTest {
        private CreateContactViewModel subject;
        private ContactRepositoryMock mockRepository;

        public CreateContactViewModelTest() {
            mockRepository = new ContactRepositoryMock();
            subject = new CreateContactViewModel(mockRepository);
        }

        [Fact]
        public void SavesNewContact() {
            //given that SaveContact returns true
            var expected = CreateCodesEnum.OK;
            mockRepository.AddHandlers()
                          .SaveContact(Contact => expected);

            // when I save
            var actual = subject.Save();

            // the repository (and hence the ViewModel) return true
            Assert.Equal(expected, actual);
        }
    }
}