using static DxLibDLL.DX;

namespace MusicGameBPMSample
{
	class Program
	{
		static void Main(string[] args)
		{
			ChangeWindowMode(1);

			DxLib_Init();

			while(ProcessMessage() == 0)
			{
				ClearDrawScreen();

				if(CheckHitKey(KEY_INPUT_ESCAPE) == 1)
				{
					break;
				}

				ScreenFlip();
			}

			DxLib_End();
		}
	}
}
