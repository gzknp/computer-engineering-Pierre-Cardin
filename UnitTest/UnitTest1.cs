using NUnit.Framework;
using cengPC;
using cengPC.Model;
using Xamarin.Forms;
using cengPC.ViewModels;
using AutoFixture;
using System.Linq;
using Moq;
using Autofac.Extras.Moq;
using FluentAssertions;
using System.Threading.Tasks;
using System;

namespace UnitTest
{
    [TestFixture]
    public class Tests
    {
        private Fixture _fixture;
        public Tests() => _fixture = new Fixture();

        [Test]
        public void SelectedCategoryNotNull()
        {
            using(var mock=AutoMock.GetLoose())
            {
                var categoryViewModel = mock.Create<CategoryViewModel>();
                categoryViewModel.SelectedCategory.Should().NotBeNull();
            }
        }
        [Test]
        public void LoginCommanNotNull()
        {
            using (var mock=AutoMock.GetLoose())
            {
                var loginViewModel = mock.Create<LoginViewModel>();
                loginViewModel.LoginCommand.Should().NotBeNull();
            }
        }
        [Test]
        public void RegisterIsBusy()
        {
            using (var mock= AutoMock.GetLoose())
            {
                var registerViewModel = mock.Create<RegisterViewModel>();
                registerViewModel.IsBusy.Should().BeFalse();
            }
        }
        [Test]
        public void CcvBeGreaterOrEqual()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var odemeViewModel = mock.Create<OdemeViewModel>();
                odemeViewModel.Ccv.Should().BeGreaterOrEqualTo(0);
            }
        }
        [Test]
        public void RegisterOdemeCommandCanExecute()
        {
            using (var mock=AutoMock.GetLoose())
            {
                var odemeViewModel = mock.Create<OdemeViewModel>();
                odemeViewModel.RegisterOdemeCommand.ChangeCanExecute();

            }
        }
        [Test]
        public void SelectedProductItemNotBeNull()
        {
            using (var mock=AutoMock.GetLoose())
            {
                var productDetailsViewModel = mock.Create<ProductDetailsViewModel>();

                productDetailsViewModel.SelectedProductItem.Should().NotBeNull();

            }
        }
        [Test]
        public void TotalProductItemsZeroDefault()
        {
            using (var mock=AutoMock.GetLoose())
            {
                var categoryViewModel = mock.Create<CategoryViewModel>();
                categoryViewModel.TotalProductItems.Should().Equals(0);
            }
        }
        [Test]
        public async Task ProductItemsByCategoryEqualsToSelectedCategory()
        {
            using (var mock=AutoMock.GetLoose())
            {
                var categoryViewModel = mock.Create<CategoryViewModel>();
                categoryViewModel.ProductItemsByCategory.Equals(categoryViewModel.SelectedCategory);
            }
        }
       


    }
}