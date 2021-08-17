using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Tuan2.Views
{
    public class NumericValidationBehavior
    {
        public static readonly BindableProperty AttachBehaviorProperty =
            BindableProperty.CreateAttached(
                                "AttachBehavior",
                                typeof(bool),
                                typeof(NumericValidationBehavior),
                                false,
                                propertyChanged: OnAttachBehaviorChanged);

        public static void OnAttachBehaviorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Entry entry = bindable as Entry;
            if(entry == null)
            {
                return;
            }
            bool attachBehavior = (bool)newValue;
            if (attachBehavior)
            {
                entry.TextChanged += OnEntryTextChanged;
            }
            else
            {
                entry.TextChanged -= OnEntryTextChanged;
            }
        }

        private static void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            double result;
            bool isValid = double.TryParse(e.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Blue : Color.Red;
        }

        public static bool GetAttachBehavior(BindableObject view)
        {
            return (bool)view.GetValue(AttachBehaviorProperty);
        }
        public static void SetAttachBehavior(BindableObject view, bool value)
        {
            view.SetValue(AttachBehaviorProperty, value);
        }
    }
}
