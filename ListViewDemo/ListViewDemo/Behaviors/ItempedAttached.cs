using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListViewDemo.Behaviors
{
    public class ItempedAttached
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.CreateAttached(
            propertyName:"Command",
            returnType:typeof(ICommand),
            declaringType:typeof(ListView),
            defaultValue:null,
            defaultBindingMode:BindingMode.OneWay,
            validateValue:null,
            propertyChanged: OnItemTappedChanged);

        public static ICommand GetItemTapped(BindableObject bindable)
        {
            return (ICommand)bindable.GetValue(CommandProperty);
        }

        private static void SetItemTapped(BindableObject bindable, ICommand value)
        {
            bindable.SetValue(CommandProperty, value);
        }

        private static void OnItemTappedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as ListView;

            if(control != null)
            {
               
            }
                
        }
    }
}
