using Microsoft.AspNetCore.Components;
using Domains.Models;

using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RadzenProjectSampl.Shared
{
    public partial class Product_View : ComponentBase
    {
        private int slideIndex = 1;

        private int Quantity = 1;
        private string SelectedSize;
        private string SelectedStitching;
        private bool ShowInstructions => SelectedStitching == "Unstitched";
        ProductDetail products = new ProductDetail();
        Product Product = new Product();
        protected override async Task OnInitializedAsync()
        {
            try
            {
                var response = await productService.GetProducts();
                if (response.IsSuccessStatusCode)
                {
                    Product = response.ResultData as Product;
                }
                ShowSlide(slideIndex);
            }
            catch (Exception)
            {

                throw;
            }

        }


        //private List<Slide> Slides = new List<Slide>
        /*{
            new Slide { SlideIndex = 1, ImageUrl = "images/image (1).jpeg", Caption = "The Woods" },
            new Slide { SlideIndex = 2, ImageUrl = "images/image (2).jpeg", Caption = "Cinque Terre" },
            new Slide { SlideIndex = 3, ImageUrl = "images/image (3).jpeg", Caption = "Mountains and fjords" },
            new Slide { SlideIndex = 4, ImageUrl = "images/image (4).jpeg", Caption = "Northern Lights" },
            new Slide { SlideIndex = 5, ImageUrl = "images/image (5).jpeg", Caption = "Nature and sunrise" },
            new Slide { SlideIndex = 6, ImageUrl = "images/image (1).jpeg", Caption = "Snowy Mountains" },
            new Slide { SlideIndex = 7, ImageUrl = "images/image (1).jpeg", Caption = "Snowy Mountains" },
            new Slide { SlideIndex = 8, ImageUrl = "images/image (1).jpeg", Caption = "Snowy Mountains" },
        };*/


        private void ChangeSlide(int n)
        {
            slideIndex += n;
            if (slideIndex > Product.Images.Count)
            {
                slideIndex = 1;
            }
            if (slideIndex < 1)
            {
                slideIndex = Product.Images.Count;
            }
            ShowSlide(slideIndex);
        }

        private void ShowSlide(int n)
        {
            try
            {

                slideIndex = n;
                caption = Product.Images.First(s => s.ImageID == slideIndex).Caption;
                StateHasChanged();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void SelectSize(string size)
        {
            SelectedSize = size;
        }

        private void SelectStitching(string stitching)
        {
            SelectedStitching = stitching;
        }

        private void IncreaseQuantity()
        {
            Quantity++;
        }

        private void DecreaseQuantity()
        {
            if (Quantity > 1)
            {
                Quantity--;
            }
        }

        private void AddToCart()
        {
            // Add to cart logic
        }

        private void QueryThroughWhatsapp()
        {
            // WhatsApp query logic
        }
    }

}

