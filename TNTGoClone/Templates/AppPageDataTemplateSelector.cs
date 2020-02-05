using System;
using TNTGoClone.ContentViews;
using TNTGoClone.Models;
using Xamarin.Forms;

namespace TNTGoClone.Templates
{
    public class AppPageDataTemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate _live;
        private readonly DataTemplate _movie;
        private readonly DataTemplate _show;
        private readonly DataTemplate _extra;

        public AppPageDataTemplateSelector()
        {
            _live = new DataTemplate(typeof(LiveContentView));
            _movie = new DataTemplate(typeof(MovieContentView));
            _show = new DataTemplate(typeof(ShowContentView));
            _extra = new DataTemplate(typeof(ExtraContentView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is AppPage appPage)
            {
                if (appPage.Type == AppPageType.Live)
                    return _live;

                if (appPage.Type == AppPageType.Movie)
                    return _movie;

                if (appPage.Type == AppPageType.Show)
                    return _show;

                if (appPage.Type == AppPageType.Extra)
                    return _extra;

                return new DataTemplate(typeof(ContentView));
            }

            return new DataTemplate(typeof(ContentView));
        }
    }
}
