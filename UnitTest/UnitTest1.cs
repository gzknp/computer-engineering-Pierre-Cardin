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
                var viewModel = mock.Create<CategoryViewModel>();
                viewModel.SelectedCategory.Should().NotBeNull();
            }
        }
        [Test]
        public void LoginCommanNotNull()
        {
            using (var mock=AutoMock.GetLoose())
            {
                var viewModel = mock.Create<LoginViewModel>();
                viewModel.LoginCommand.Should().NotBeNull();
            }
        }
        [Test]
        public void SelectedProductItemNotBeNull()
        {
            using (var mock=AutoMock.GetLoose())
            {
                var viewModel = mock.Create<ProductDetailsViewModel>();

                viewModel.SelectedProductItem.Should().NotBeNull();

            }
        }
        [Test]
        public void TotalProductItemsZeroDefault()
        {
            using (var mock=AutoMock.GetLoose())
            {
                var category = mock.Create<CategoryViewModel>();
                category.TotalProductItems.Should().Equals(0);
            }
        }
        [Test]
        public async Task ProductItemsByCategoryEqualsToPIBC()
        {
            using (var mock=AutoMock.GetLoose())
            {
                var viewModel = mock.Create<CategoryViewModel>();
                viewModel.ProductItemsByCategory.Equals(viewModel.ProductItemsByCategory);
            }
        }
       


    }
}