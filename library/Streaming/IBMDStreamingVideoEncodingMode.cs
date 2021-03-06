﻿using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// Represents an encoded video mode
	/// </summary>
	[ComImport]
	[Guid("1AB8035B-CD13-458D-B6DF-5E8F7C2141D9")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBMDStreamingVideoEncodingMode
	{
		int GetName([Out, MarshalAs(UnmanagedType.BStr)] out string name);
		uint GetPresetID();
		uint GetSourcePositionX();
		uint GetSourcePositionY();
		uint GetSourceWidth();
		uint GetSourceHeight();
		uint GetDestWidth();
		uint GetDestHeight();
		int GetFlag([In] BMDStreamingEncodingModePropertyID cfgID, [Out, MarshalAs(UnmanagedType.Bool)] out bool value);
		int GetInt([In] BMDStreamingEncodingModePropertyID cfgID, [Out] out long value);
		int GetFloat([In] BMDStreamingEncodingModePropertyID cfgID, [Out] out double value);
		int GetString([In] BMDStreamingEncodingModePropertyID cfgID, [Out, MarshalAs(UnmanagedType.BStr)] out string value);
		int CreateMutableVideoEncodingMode([Out] out IBMDStreamingMutableVideoEncodingMode newEncodingMode); // Creates a mutable copy of the encoding mode
	}
}
