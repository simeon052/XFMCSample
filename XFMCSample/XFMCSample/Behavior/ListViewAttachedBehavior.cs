using System.Windows.Input;
using Xamarin.Forms;

namespace XFMCSample.Behavior
{
    public static class ListViewAttachedBehavior
    {
        public static readonly BindableProperty ItemTappedCmdProperty =
            BindableProperty.CreateAttached(
                "ItemTappedCmd",
                typeof(ICommand),
                typeof(ListViewAttachedBehavior),
                null,
                propertyChanged: OnCommandItemTapped);

        static void OnCommandItemTapped(BindableObject view, object oldValue, object newValue)
        {
            var entry = view as ListView;
            if (entry == null)
                return;

            entry.ItemTapped += (sender, e) =>
                {
                    var command = (newValue as ICommand);
                    if (command == null)
                        return;

                    if (command.CanExecute(e.Item))
                    {
                        command.Execute(e.Item);
                    }

                };
        }

        public static readonly BindableProperty ItemSelectedCmdProperty =
            BindableProperty.CreateAttached(
                "ItemSelectedCmd",
                typeof(ICommand),
                typeof(ListViewAttachedBehavior),
                null,
                propertyChanged: OnCommandItemSelected);

        static void OnCommandItemSelected(BindableObject view, object oldValue, object newValue)
        {
            var entry = view as ListView;
            if (entry == null)
                return;
            entry.ItemSelected += (sender, e) =>
                {
                    var command = (newValue as ICommand);
                    if (command == null)
                        return;

                    if (command.CanExecute(e.SelectedItem))
                    {
                        command.Execute(e.SelectedItem);
                    }

                };
        }
    }
}
