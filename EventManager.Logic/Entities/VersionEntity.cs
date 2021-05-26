//@CodeCopy

using EventManager.Contracts;

namespace EventManager.Logic.Entities
{
	internal abstract partial class VersionEntity : IdentityEntity, IVersionable
	{
		public byte[] RowVersion { get; set; }
	}
}
