using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Working.Models
{
    public class MyViewModel
    {
        private List<Image> images;

        public List<Image> GetImages()
        {
            return images;
        }

        public void SetImages(List<Image> value)
        {
            images = value;
        }

        private List<Town> towns;

        public List<Town> GetTowns()
        {
            return towns;
        }

        public void SetTowns(List<Town> value)
        {
            towns = value;
        }
    }
}