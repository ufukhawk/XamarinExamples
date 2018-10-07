namespace PickerWithIcon.iOS
{
	public class CustomPickerRenderer : PickerRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged(e);

			var element = (CustomPicker)this.Element;

			    if (this.Control != null && this.Element != null && !string.IsNullOrEmpty(element.Image)){
				var downarrow = UIImage.FromBundle(element.Image);
				Control.RightViewMode = UITextFieldViewMode.Always;
				Control.RightView = new UIImageView(downarrow);
			    }
		}
	}