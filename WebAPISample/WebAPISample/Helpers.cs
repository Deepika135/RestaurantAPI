using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPISample
{
	public class Helpers
	{
		public const string SampleApiRoute_Restaurant_List = "api/v1/RestaurantList";

		public const string SampleApiRoute_Restaurant_Add = "api/v1/AddRestaurant";

		public const string SampleApiRoute_Restaurant_AddReview = "api/v1/Restaurant/AddReview";

		public const string SampleApiRoute_Restaurant_Reviews_ListByUser = "api/v1/Restaurant/UserReviews";

		public const string SampleApiRoute_Restaurant_DeleteReview = "api/v1/Restaurant/DeleteReview";
	}
}