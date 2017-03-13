using Android.App;
using Android.Widget;
using Android.OS;
using CheeseBind;

namespace Dataku {
	[Activity(Label = "Dataku", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity {

		[BindView(Resource.Id.btn_submit)] public Button btnSubmit;
		[BindView(Resource.Id.txt_test)] public TextView txtTest;

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);
			Cheeseknife.Bind(this);
		}

		[OnClick(Resource.Id.btn_submit)]
		public void btnSubmitClick() {
			txtTest.Text = "Isfaganteng.";
		}
	}
}

