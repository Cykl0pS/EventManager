//@CodeCopy

namespace EventManager.Transfer.Models
{
	public partial class VersionModel : IdentityModel, Contracts.IVersionable
	{
		public byte[] RowVersion { get; set; }
	}
}
