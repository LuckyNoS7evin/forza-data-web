﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ForzaData.Core
{
	/// <summary>
	/// Forza Horizon 4 / Forza Motorsport 7 Data Out structure
	/// </summary>
	public struct ForzaDataStruct
	{
		/// <summary>
		/// Protocol version
		/// </summary>
		public ForzaDataVersion Version;

		/// <summary>
		/// Sled data
		/// </summary>
		public ForzaSledDataStruct Sled;

		/// <summary>
		/// Car dash data
		/// </summary>
		public ForzaCarDashDataStruct CarDash;

		/// <summary>
		/// Horizon specific data part 1
		/// </summary>
		public byte[] HorizonData1;

		/// <summary>
		/// Horizon specific data part 2
		/// </summary>
		public byte[] HorizonData2;
	}
}
