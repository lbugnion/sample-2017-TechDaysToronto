using Data;
using System;

using UIKit;

namespace HelloIos
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            MyButton.TouchUpInside += async (s, e) =>
            {
                try
                {
                    var service = new YoutubeService();
                    MyLabel.Text = await service.Refresh();
                }
                catch (Exception ex)
                {
                    MyLabel.Text = ex.Message;
                }
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}