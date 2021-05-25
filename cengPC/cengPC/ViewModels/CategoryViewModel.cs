using cengPC.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace cengPC.ViewModels
{
    public class CategoryViewModel:BaseViewModel
        
    {
        private Category _SelectedCategory;
        public Category SelectedCategory
        {
            set
            {
                _SelectedCategory = value;
                OnPropertyChanged();
            }
            get
            {
                return _SelectedCategory;
            }
        }
        public ObservableCollection<ProductItem> ProductItemsByCategory { get; set; }
        public ObservableCollection<string> FilterOptions { get; }

        private int _TotalProductItems;
        public int TotalProductItems
        {
            set
            {
                _TotalProductItems = value;
                OnPropertyChanged();
            }
            get
            {
                return _TotalProductItems;
            }
        }
        public CategoryViewModel(Category category)
        {
            SelectedCategory = category;
            ProductItemsByCategory = new ObservableCollection<ProductItem>();
            GetProductItems(category.CategoryID);       

        }
        


    private async void GetProductItems(int categoryID)
        {
            var data = await new ProductItemService().GetProductItemsByCategoryAsync(categoryID);
            ProductItemsByCategory.Clear();
            foreach(var item in data)
            {
                ProductItemsByCategory.Add(item);
               
            }
            TotalProductItems = ProductItemsByCategory.Count;
        }
    }
}
