using Documently.Commands;

namespace Documently.Messages.DocCollectionCmds
{
	public interface Create : Command
	{
		string Name { get; }
	}
}