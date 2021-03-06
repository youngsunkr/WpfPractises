﻿namespace WpfTestApp
{
	public static class DataLoader
	{
		/// <summary>データをロードします。</summary>
		/// <param name="dataFilePath">データファイルのフルパスを表す文字列。</param>
		/// <returns>ロードしたデータを表すWpfTestAppData。</returns>
		public static WpfTestAppData Load(string dataFilePath)
		{
			if (dataFilePath == string.Empty) { return DataLoader.createNewTestData(); }
			else { return DataLoader.loadFromFile(dataFilePath); }
		}

		/// <summary>新規テストデータを作成します。</summary>
		/// <returns>新規テストデータを表すWpfTestAppData。</returns>
		private static WpfTestAppData createNewTestData()
		{
			var appData = new WpfTestAppData();
			appData.Student.Name = "新しい生徒";
			appData.Student.ClassNumber = "所属クラス";
			appData.Student.Sex = "男";

			appData.Physicals.Add(appData.CreateNewData<PhysicalInformation>());
			appData.TestPoints.Add(appData.CreateNewData<TestPointInformation>());

			return appData;
		}

		/// <summary>データファイルからロードします。</summary>
		/// <param name="dataFilePath">データファイルのフルパスを表す文字列。</param>
		/// <returns>データファイルからロードしたWpfTestAppData。</returns>
		private static WpfTestAppData loadFromFile(string dataFilePath) { return new WpfTestAppData(); }
	}
}
