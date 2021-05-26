//@CodeCopy

namespace EventManager.Contracts
{
	public partial interface IVersionable : IIdentifiable
	{
		byte[] RowVersion { get; }
	}
}
