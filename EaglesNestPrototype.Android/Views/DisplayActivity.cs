
using Android.App;
using Android.OS;

namespace EaglesNestPrototype.Android.Views
{
    [Activity(Label = "DisplayActivity")]
    public class DisplayActivity : Activity
    {
        //private Binding<string, string> _studentIdBinding;
        //private Binding<string, string> _firstNameBinding;
        //private Binding<string, string> _lastNameBinding;
        //private TextView _studentID;
        //private TextView _firstName;
        //private TextView _lastName;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DisplayActivityLayout);

            //  _studentIdBinding = this.SetBinding(() => displayViewModedel.studentId, () => PreviousMessage.Text);
        }

        //public MainViewModel mainVm => MainActivity.Locator.Main;
        //public DisplayViewModel displayViewModedel;

    }
}