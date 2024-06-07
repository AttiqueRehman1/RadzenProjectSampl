using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RadzenProjectSampl.Shared
{
    public partial class ImageSlideSHow : ComponentBase
    {
        private ElementReference slideshowWrapper;
        private List<string> Images = new List<string>
        {
            "images/image (1).jpeg",
            "images/image (2).jpeg",
            "images/image (3).jpeg",
            "images/image (4).jpeg",
            "images/image (5).jpeg",
        };

        private int currentIndex = 0;
        private Timer timer;

        protected override void OnInitialized()
        {
            timer = new Timer(ChangeSlide, null, 5000, 5000);
        }

        private void ChangeSlide(object state)
        {
            InvokeAsync(() =>
            {
                ShowNextSlide();
                StateHasChanged();
            });
        }

        private void ShowPreviousSlide()
        {
            currentIndex = (currentIndex - 1 + Images.Count) % Images.Count;
        }

        private void ShowNextSlide()
        {
            currentIndex = (currentIndex + 1) % Images.Count;
        }

        private void SetCurrentSlide(int index)
        {
            currentIndex = index;
            timer.Change(5000, 5000); // Reset the timer when the user manually changes the slide
        }

        public void Dispose()
        {
            timer?.Dispose();
        }
    }
}
