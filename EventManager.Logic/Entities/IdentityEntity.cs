//@CodeCopy

using CommonBase.Extensions;
using EventManager.Contracts;

namespace EventManager.Logic.Entities
{
	internal abstract partial class IdentityEntity : IIdentifiable
	{
		public int Id { get; set; }
	}
}
