namespace UGMan6000.Transparent
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ApplicationController controller = new ApplicationController())
			{
				new ConsoleView(controller).Interact();
			}
		}
	}
}
