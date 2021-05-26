//@CodeCopy

namespace EventManager.Transfer.Models
{
	public partial class IdentityModel : TransferObject, Contracts.IIdentifiable
	{
		public int Id { get; set; }
	}
}
