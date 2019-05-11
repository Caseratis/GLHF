using Terraria.ModLoader;

namespace GLHF
{
	class GLHF : Mod
	{
		public GLHF()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
