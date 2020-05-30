// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using SoundCloudClone.Models.App;
using UIKit;

namespace SoundCloudClone.iOS.Controls
{
	public partial class SearchResultsCell : UITableViewCell
	{
		public SearchResultsCell (IntPtr handle) : base (handle)
		{
		}

		public void Update(SearchSuggestion searchSuggestion)
		{
			Name.Text = searchSuggestion.Description;
		}

		public void ChangeStyle(UIColor color, UIImage _cellIcon)
		{
			Name.TextColor = color;
			Icon.Image = _cellIcon;
        }

		internal void ChangeFont()
		{
			Name.Font = Constants.DefaultFont;
		}
    }
}
