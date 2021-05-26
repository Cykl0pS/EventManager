//@CodeCopy

namespace EventManager.Contracts
{
	public partial interface ICopyable<T>
	{
		void CopyProperties(T other);
	}
}
