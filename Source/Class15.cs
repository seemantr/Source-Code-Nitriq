using Microsoft.Win32;
using ns1;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

[DesignTimeVisible(false)]
internal class Class15 : LicenseProvider
{
	internal class Class16
	{
		internal static string string_0;

		internal static string string_1;

		internal static string string_2;

		internal static string string_3;

		internal static string string_4;

		internal static string string_5;

		internal static string string_6;

		internal static string string_7;

		internal static string string_8;

		internal static string string_9;

		internal static string string_10;

		internal static string string_11;

		internal static string string_12;

		internal static string string_13;

		internal static string string_14;

		internal static string string_15;

		internal static string string_16;

		internal static string string_17;

		internal static string string_18;

		internal static string string_19;

		internal static string string_20;

		internal static string string_21;

		internal static string string_22;

		internal static string string_23;

		internal static string string_24;

		internal static string string_25;

		internal static string string_26;

		internal static string string_27;

		internal static string string_28;

		internal static string string_29;

		internal static string string_30;

		internal static string string_31;

		internal static string string_32;

		internal static string string_33;

		static Class16()
		{
			Class15.Class16.string_0 = "Software\\CLASSES\\CLSID\\";
			Class15.Class16.string_1 = "CLSID\\";
			Class15.Class16.string_2 = "\\IsolatedStorage\\";
			Class15.Class16.string_3 = "[AssemblyName]";
			Class15.Class16.string_4 = "[AssemblyVersion]";
			Class15.Class16.string_5 = "[AssemblyCopyright]";
			Class15.Class16.string_6 = "[AssemblyTrademark]";
			Class15.Class16.string_7 = "[AssemblyCompany]";
			Class15.Class16.string_8 = "[AssemblyProduct]";
			Class15.Class16.string_9 = "[AssemblyDescription]";
			Class15.Class16.string_10 = "[AssemblyTitle]";
			Class15.Class16.string_11 = "####-####-####-####-####-####";
			Class15.Class16.string_12 = "[current_days]";
			Class15.Class16.string_13 = "[days_left]";
			Class15.Class16.string_14 = "[global_left]";
			Class15.Class16.string_15 = "[max_days]";
			Class15.Class16.string_16 = "[expiration_date]";
			Class15.Class16.string_17 = "[current_date]";
			Class15.Class16.string_18 = "[current_execution]";
			Class15.Class16.string_19 = "[max_executions]";
			Class15.Class16.string_20 = "[executions_left]";
			Class15.Class16.string_21 = "[max_instances]";
			Class15.Class16.string_22 = "[current_global]";
			Class15.Class16.string_23 = "[max_global]";
			Class15.Class16.string_24 = "X";
			Class15.Class16.string_25 = "G";
			Class15.Class16.string_26 = "V";
			Class15.Class16.string_27 = "I";
			Class15.Class16.string_28 = "C";
			Class15.Class16.string_29 = "D";
			Class15.Class16.string_30 = "L";
			Class15.Class16.string_31 = "U";
			Class15.Class16.string_32 = "*.";
			Class15.Class16.string_33 = ".";
		}
	}

	internal class Class17
	{
		internal DateTime dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

		internal DateTime dateTime_1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

		internal int int_0;

		internal int int_1;

		internal int int_2 = 1;

		internal ulong ulong_0;

		internal int int_3;

		internal string string_0 = "";

		private string string_1 = "";

		internal bool method_0(string string_2, byte[] byte_0, byte[] byte_1)
		{
			byte[] array = Convert.FromBase64String(string_2);
			ICryptoTransform transform = new RijndaelManaged
			{
				Mode = CipherMode.CBC
			}.CreateDecryptor(byte_0, byte_1);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array2 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			string_2 = Encoding.Unicode.GetString(array2, 0, array2.Length);
			bool result;
			try
			{
				string[] array3 = string_2.Split(new char[]
				{
					'|'
				});
				for (int i = 0; i < array3.Length / 2; i++)
				{
					if (array3[i * 2] == Class15.Class16.string_24)
					{
						this.int_0 = this.method_2(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class15.Class16.string_25)
					{
						this.int_1 = this.method_2(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class15.Class16.string_26)
					{
						this.int_2 = this.method_2(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class15.Class16.string_27)
					{
						this.int_3 = this.method_2(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class15.Class16.string_28)
					{
						this.ulong_0 = this.method_3(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class15.Class16.string_29)
					{
						this.dateTime_0 = this.method_4(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class15.Class16.string_30)
					{
						this.dateTime_1 = this.method_4(array3[i * 2 + 1]);
					}
					else if (array3[i * 2] == Class15.Class16.string_31)
					{
						this.string_0 = array3[i * 2 + 1];
					}
				}
				return true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		internal bool method_1(string string_2)
		{
			return string_2 == "1";
		}

		internal int method_2(string string_2)
		{
			return Convert.ToInt32(string_2);
		}

		internal ulong method_3(string string_2)
		{
			return Convert.ToUInt64(string_2);
		}

		internal DateTime method_4(string string_2)
		{
			string value = string_2.Substring(0, 4);
			string value2 = string_2.Substring(4, 2);
			string value3 = string_2.Substring(6, 2);
			return new DateTime(Convert.ToInt32(value), Convert.ToInt32(value2), Convert.ToInt32(value3));
		}

		internal string method_5(byte[] byte_0, byte[] byte_1)
		{
			this.string_1 = "";
			this.method_6(Class15.Class16.string_24);
			this.method_7(this.int_0);
			this.method_6(Class15.Class16.string_25);
			this.method_7(this.int_1);
			this.method_6(Class15.Class16.string_26);
			this.method_7(this.int_2);
			this.method_6(Class15.Class16.string_27);
			this.method_7(this.int_3);
			this.method_6(Class15.Class16.string_28);
			this.method_7(this.ulong_0);
			this.method_6(Class15.Class16.string_29);
			this.method_7(this.dateTime_0);
			this.method_6(Class15.Class16.string_30);
			this.method_7(this.dateTime_1);
			this.method_6(Class15.Class16.string_31);
			this.method_7(this.string_0);
			byte[] bytes = Encoding.Unicode.GetBytes(this.string_1);
			ICryptoTransform transform = new RijndaelManaged
			{
				Mode = CipherMode.CBC
			}.CreateEncryptor(byte_0, byte_1);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] inArray = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			this.string_1 = Convert.ToBase64String(inArray);
			return this.string_1;
		}

		internal void method_6(string string_2)
		{
			if (this.string_1.Length > 0)
			{
				this.string_1 += "|";
			}
			this.string_1 += string_2;
		}

		internal void method_7(object object_0)
		{
			this.string_1 += "|";
			if (object_0 is int)
			{
				this.string_1 += ((int)object_0).ToString();
				return;
			}
			if (object_0 is DateTime)
			{
				this.string_1 = this.string_1 + ((DateTime)object_0).Year.ToString("D4") + ((DateTime)object_0).Month.ToString("D2") + ((DateTime)object_0).Day.ToString("D2");
				return;
			}
			if (object_0 is ulong)
			{
				this.string_1 += ((ulong)object_0).ToString();
				return;
			}
			if (!(object_0 is string))
			{
				throw new Exception("Invalid Key Type");
			}
			this.string_1 += object_0.ToString();
		}
	}

	private class Class18
	{
		internal string string_0 = "";

		internal ArrayList arrayList_0 = new ArrayList();

		internal bool bool_0 = true;

		internal bool bool_1 = true;

		internal bool bool_2;

		internal bool bool_3;

		internal bool bool_4;

		internal bool bool_5 = true;

		internal bool bool_6;

		internal bool bool_7;

		internal bool bool_8 = true;

		internal bool bool_9;

		internal bool bool_10;

		internal string string_1 = "";

		internal bool bool_11 = true;

		internal bool bool_12;

		internal bool bool_13;

		internal string string_2 = "http://";

		internal string string_3 = Class15.Class16.string_11;

		internal int int_0 = 5;

		internal int int_1;

		internal bool bool_14;

		internal bool bool_15;

		internal int int_2 = 31;

		internal bool bool_16;

		internal DateTime dateTime_0 = DateTime.Now.AddDays(1.0);

		internal bool bool_17;

		internal int int_3 = 20;

		internal bool bool_18;

		internal int int_4 = 10;

		internal bool bool_19;

		internal int int_5 = 60;

		internal bool bool_20;

		internal int int_6 = 1;

		internal bool bool_21;

		internal bool bool_22 = true;

		internal bool bool_23 = true;

		internal bool bool_24 = true;

		internal bool bool_25 = true;

		internal bool bool_26 = true;

		internal bool bool_27 = true;

		internal bool bool_28 = true;

		internal bool bool_29 = true;

		internal bool bool_30 = true;

		internal bool bool_31 = true;

		internal bool bool_32 = true;

		internal bool bool_33 = true;

		internal bool bool_34;

		internal string string_4 = "You are on day [current_days] of your [max_days] day evaluation period. Your trial period is expired! You need to purchase a license to run this software.";

		internal string string_5 = "Your expiration date([expiration_date]) is reached! You need to purchase a license file to run this software.";

		internal string string_6 = "You have used this software [current_execution] times out of a maximum of [max_executions]. You have [executions_left] uses left. Your trial period is expired! You need to purchase a license to run this software.";

		internal string string_7 = "This software won't run without a valid license file. Either a valid license file could not be found or your license file is expired.";

		internal string string_8 = "You can only run maximal [max_instances] instances of this software at the same time.";

		internal string string_9 = "You are on minute [current_global] of your [max_global] minutes evaluation period. Your trial period is expired! You need to purchase a license to run this software.";

		internal string string_10 = "Your runtime is exceeded!";

		internal string string_11 = "Nag Screen! This message will disappear when a valid license file is installed.";

		internal string string_12 = "";

		internal string string_13 = "*.license";

		internal Hashtable hashtable_0 = new Hashtable();

		internal bool method_0(byte[] byte_0)
		{
			bool result;
			try
			{
				MemoryStream memoryStream = new MemoryStream(byte_0);
				BinaryReader binaryReader = new BinaryReader(memoryStream);
				memoryStream.Position = 0L;
				byte[] array = binaryReader.ReadBytes(binaryReader.ReadInt32());
				byte[] byte_ = binaryReader.ReadBytes((int)(memoryStream.Length - 4L - (long)array.Length));
				binaryReader.Close();
				if (Class15.smethod_10(Class15.smethod_9("<RSAKeyValue><Modulus>lw8fI6+kGHzjGTnm6akQHIPzG6ZGkRLcaXv/cA14YnyzStqWik3BS0Lm3DCbPDziXPUqLk469++sK1TwUnXojFYBdZR7RtH5dP+WbXm5H8pgOWnsd6mqowPCStvk/IWe9FiwAthLTkRBJS8u69r9kAM5UwnZTnx5ojkBPXc5LroODTmhk7JPPc3BdWTqhbNViBlnugn+JXIqqpkv5KY3IfTZEiRMTJJ06wyXvUX18O0IfoMJrHEqMT3x4Gd+KScKhT202WeTrdBiBvvleoFrd16ZVNa/jDiQ4pDjmguypFbKIIYwS0nzuy9lEI1oNoPdBHKUTRJ90WNf9eAKys7b7Q==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>"), byte_, array))
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		internal bool method_1(byte[] byte_0)
		{
			bool result;
			try
			{
				MemoryStream memoryStream = new MemoryStream(byte_0);
				BinaryReader binaryReader = new BinaryReader(memoryStream);
				memoryStream.Position = 0L;
				byte[] array = binaryReader.ReadBytes(binaryReader.ReadInt32());
				byte[] array2 = binaryReader.ReadBytes((int)(memoryStream.Length - 4L - (long)array.Length));
				binaryReader.Close();
				string @string = Encoding.Unicode.GetString(array2, 0, array2.Length);
				this.arrayList_0.Clear();
				this.hashtable_0.Clear();
				string[] array3 = @string.Split(new char[]
				{
					'|'
				});
				for (int i = 0; i < array3.Length / 2; i++)
				{
					string key;
					switch (key = array3[i * 2])
					{
					case "LicenseServerEnabled":
						this.bool_2 = this.method_2(array3[i * 2 + 1]);
						break;
					case "FloatingLicense":
						this.bool_3 = this.method_2(array3[i * 2 + 1]);
						break;
					case "R_License":
						this.bool_0 = this.method_2(array3[i * 2 + 1]);
						break;
					case "D_License":
						this.bool_1 = this.method_2(array3[i * 2 + 1]);
						break;
					case "HardwareLock":
						this.bool_4 = this.method_2(array3[i * 2 + 1]);
						break;
					case "HDD":
						this.bool_5 = this.method_2(array3[i * 2 + 1]);
						break;
					case "CPU":
						this.bool_6 = this.method_2(array3[i * 2 + 1]);
						break;
					case "BIOS":
						this.bool_8 = this.method_2(array3[i * 2 + 1]);
						break;
					case "OS":
						this.bool_9 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Individual":
						this.bool_10 = this.method_2(array3[i * 2 + 1]);
						break;
					case "IndividualV":
						this.string_1 = this.method_4(array3[i * 2 + 1]);
						break;
					case "MAC":
						this.bool_7 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Mainboard":
						this.bool_11 = this.method_2(array3[i * 2 + 1]);
						break;
					case "LicenseLocks":
						this.bool_12 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Internal":
						this.bool_13 = this.method_2(array3[i * 2 + 1]);
						break;
					case "LicenseServer":
						this.string_2 = this.method_4(array3[i * 2 + 1]);
						break;
					case "HardwareID":
						this.string_3 = this.method_4(array3[i * 2 + 1]);
						break;
					case "FloatingLicenseValue":
						this.int_0 = this.method_3(array3[i * 2 + 1]);
						break;
					case "ToleranceLevel":
						this.int_1 = this.method_3(array3[i * 2 + 1]);
						break;
					case "RequireVistaAdmin":
						this.bool_14 = this.method_2(array3[i * 2 + 1]);
						break;
					case "ExpirationDays":
						this.bool_15 = this.method_2(array3[i * 2 + 1]);
						break;
					case "ExpirationDays_Value":
						this.int_2 = this.method_3(array3[i * 2 + 1]);
						break;
					case "ExpirationDate":
						this.bool_16 = this.method_2(array3[i * 2 + 1]);
						break;
					case "ExpirationDate_Value":
						this.dateTime_0 = this.method_5(array3[i * 2 + 1]);
						break;
					case "Executions":
						this.bool_17 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Executions_Value":
						this.int_3 = this.method_3(array3[i * 2 + 1]);
						break;
					case "Runtime":
						this.bool_18 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Runtime_Value":
						this.int_4 = this.method_3(array3[i * 2 + 1]);
						break;
					case "GlobalTime":
						this.bool_19 = this.method_2(array3[i * 2 + 1]);
						break;
					case "GlobalTime_Value":
						this.int_5 = this.method_3(array3[i * 2 + 1]);
						break;
					case "Instances":
						this.bool_20 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Instances_Value":
						this.int_6 = this.method_3(array3[i * 2 + 1]);
						break;
					case "Custom":
						this.bool_21 = this.method_2(array3[i * 2 + 1]);
						break;
					case "ExpirationBehaviourALL":
						this.bool_22 = this.method_2(array3[i * 2 + 1]);
						break;
					case "SearchInEmbeddedResources":
						this.bool_23 = this.method_2(array3[i * 2 + 1]);
						break;
					case "SearchOnHDD":
						this.bool_24 = this.method_2(array3[i * 2 + 1]);
						break;
					case "ShutdownProcess":
						this.bool_25 = this.method_2(array3[i * 2 + 1]);
						break;
					case "RunWithoutValidLicense":
						this.bool_26 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Days":
						this.bool_27 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Date":
						this.bool_28 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Executions":
						this.bool_29 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_NoLicenseFound":
						this.bool_31 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Instances":
						this.bool_32 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Global":
						this.bool_33 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Nag":
						this.bool_34 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Runtime":
						this.bool_30 = this.method_2(array3[i * 2 + 1]);
						break;
					case "Dialog_Days_Value":
						this.string_4 = this.method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Date_Value":
						this.string_5 = this.method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Executions_Value":
						this.string_6 = this.method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_NoLicenseFound_Value":
						this.string_7 = this.method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Instances_Value":
						this.string_8 = this.method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Global_Value":
						this.string_9 = this.method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Nag_Value":
						this.string_11 = this.method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Runtime_Value":
						this.string_10 = this.method_4(array3[i * 2 + 1]);
						break;
					case "Dialog_Box_Interface":
						this.string_12 = this.method_4(array3[i * 2 + 1]);
						break;
					case "LicenseName":
						this.string_13 = this.method_4(array3[i * 2 + 1]);
						break;
					case "KeyValueTable":
					{
						string text = this.method_4(array3[i * 2 + 1]);
						string[] array4 = text.Split(new char[]
						{
							'|'
						});
						for (int j = 0; j < array4.Length / 2; j++)
						{
							this.hashtable_0.Add(array4[j * 2], array4[j * 2 + 1]);
						}
						break;
					}
					}
				}
				return true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		internal bool method_2(string string_14)
		{
			return string_14 == "1";
		}

		internal int method_3(string string_14)
		{
			return Convert.ToInt32(string_14);
		}

		internal string method_4(string string_14)
		{
			if (string_14.Length != 0)
			{
				byte[] array = Convert.FromBase64String(string_14);
				return Encoding.Unicode.GetString(array, 0, array.Length).Trim();
			}
			return "";
		}

		internal DateTime method_5(string string_14)
		{
			string value = string_14.Substring(0, 4);
			string value2 = string_14.Substring(4, 2);
			string value3 = string_14.Substring(6, 2);
			return new DateTime(Convert.ToInt32(value), Convert.ToInt32(value2), Convert.ToInt32(value3));
		}
	}

	[GeneratedCode("wsdl", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "ActivationServiceSoap", Namespace = "http://tempuri.org/")]
	internal class Class19 : SoapHttpClientProtocol
	{
		private SendOrPostCallback sendOrPostCallback_0;

		private Class15.Delegate0 delegate0_0;

		public event Class15.Delegate0 Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.delegate0_0 = (Class15.Delegate0)Delegate.Combine(this.delegate0_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.delegate0_0 = (Class15.Delegate0)Delegate.Remove(this.delegate0_0, value);
			}
		}

		public Class19(string string_0)
		{
			base.Url = string_0;
		}

		[SoapDocumentMethod("http://tempuri.org/Activate", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		[return: XmlElement(DataType = "base64Binary")]
		public byte[] Activate([XmlElement(DataType = "base64Binary")] byte[] license)
		{
			object[] array = base.Invoke("Activate", new object[]
			{
				license
			});
			return (byte[])array[0];
		}

		public IAsyncResult method_0(byte[] byte_0, AsyncCallback asyncCallback_0, object object_0)
		{
			return base.BeginInvoke("Activate", new object[]
			{
				byte_0
			}, asyncCallback_0, object_0);
		}

		public byte[] method_1(IAsyncResult iasyncResult_0)
		{
			object[] array = base.EndInvoke(iasyncResult_0);
			return (byte[])array[0];
		}

		public void method_2(byte[] byte_0)
		{
			this.method_3(byte_0, null);
		}

		public void method_3(byte[] byte_0, object object_0)
		{
			if (this.sendOrPostCallback_0 == null)
			{
				this.sendOrPostCallback_0 = new SendOrPostCallback(this.method_4);
			}
			base.InvokeAsync("Activate", new object[]
			{
				byte_0
			}, this.sendOrPostCallback_0, object_0);
		}

		private void method_4(object object_0)
		{
			if (this.delegate0_0 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)object_0;
				this.delegate0_0(this, new Class15.EventArgs0(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}

		public void method_5(object object_0)
		{
			base.CancelAsync(object_0);
		}
	}

	[GeneratedCode("wsdl", "2.0.50727.42")]
	internal delegate void Delegate0(object sender, Class15.EventArgs0 e);

	[GeneratedCode("wsdl", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough]
	internal class EventArgs0 : AsyncCompletedEventArgs
	{
		private object[] object_0;

		internal EventArgs0(object[] object_1, Exception exception_0, bool bool_0, object object_2) : base(exception_0, bool_0, object_2)
		{
			this.object_0 = object_1;
		}

		public byte[] method_0()
		{
			base.RaiseExceptionIfNecessary();
			return (byte[])this.object_0[0];
		}
	}

	private class Class20
	{
		internal System.Threading.Timer timer_0;

		private Class15.Class18 class18_0;

		private Assembly assembly_0;

		public Class20(Class15.Class18 class18_1, Assembly assembly_1)
		{
			this.assembly_0 = assembly_1;
			this.class18_0 = class18_1;
		}

		internal void method_0(object object_0)
		{
			try
			{
				this.timer_0.Dispose();
			}
			catch
			{
			}
			try
			{
				Class33.smethod_0().method_1((Enum6)3);
				if (Class33.smethod_0().method_6() == (Enum7)2)
				{
					Class33.smethod_0().method_5(Class33.smethod_0().method_0());
				}
				if (Class33.smethod_0().method_6() == (Enum7)1)
				{
					Class33.smethod_0().method_3(Class33.smethod_0().method_0());
				}
				if (this.class18_0.bool_30)
				{
					Class15.Class21.timer_0 = new System.Threading.Timer(new TimerCallback(new Class15.Class21().method_0), null, 90000, 30000);
					if (this.class18_0.bool_25)
					{
						try
						{
							Class15.EnableWindow(Process.GetCurrentProcess().MainWindowHandle, false);
						}
						catch
						{
						}
					}
					string string_ = this.class18_0.string_10;
					Class15.ShowMessage(string_);
				}
				if (this.class18_0.bool_25)
				{
					try
					{
						Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
	}

	private class Class21
	{
		internal static System.Threading.Timer timer_0;

		internal void method_0(object object_0)
		{
			Class15.Class21.timer_0.Dispose();
			try
			{
				Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
			}
			catch
			{
			}
		}
	}

	private class Class22
	{
		internal System.Threading.Timer timer_0;

		internal int int_0;

		internal int int_1;

		internal Class15.Class23 class23_0;

		private Class15.Class18 class18_0;

		private Class15.Class17 class17_0;

		private Type type_0;

		private byte[] byte_0 = new byte[0];

		private byte[] byte_1 = new byte[0];

		public Class22(Class15.Class18 class18_1, Class15.Class17 class17_1, Type type_1, byte[] byte_2, byte[] byte_3)
		{
			this.class18_0 = class18_1;
			this.class17_0 = class17_1;
			this.type_0 = type_1;
			this.byte_0 = byte_2;
			this.byte_1 = byte_3;
		}

		internal void method_0(object object_0)
		{
			lock (Class15.object_0)
			{
				if (DateTime.Compare(DateTime.Now, this.class17_0.dateTime_0) >= 0)
				{
					this.class17_0.dateTime_0 = DateTime.Now;
					try
					{
						string string_ = Class15.Class16.string_0;
						string str = Class15.string_3 + "\\";
						RegistryKey registryKey = Registry.CurrentUser;
						if (Class15.smethod_0())
						{
							registryKey = Registry.LocalMachine;
						}
						RegistryKey registryKey2;
						if (registryKey.OpenSubKey(string_ + str, false) == null)
						{
							registryKey = Registry.CurrentUser;
							if (Class15.smethod_0())
							{
								registryKey = Registry.LocalMachine;
							}
							registryKey2 = registryKey.CreateSubKey(string_ + str);
						}
						registryKey = Registry.CurrentUser;
						if (Class15.smethod_0())
						{
							registryKey = Registry.LocalMachine;
						}
						registryKey2 = registryKey.OpenSubKey(string_ + str, true);
						if (registryKey2 != null)
						{
							registryKey2.SetValue("1", this.class17_0.method_5(this.byte_0, this.byte_1));
							registryKey2.Close();
						}
					}
					catch
					{
					}
					try
					{
						if (Class14.smethod_5(this.type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(this.type_0.Assembly).ToString()))
						{
							Class15.smethod_7(Path.GetDirectoryName(Class14.smethod_5(this.type_0.Assembly).ToString()), Class15.string_2, this.class17_0.method_5(this.byte_0, this.byte_1));
						}
					}
					catch
					{
					}
					try
					{
						FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2, FileMode.Create, FileAccess.ReadWrite);
						byte[] bytes = Encoding.Unicode.GetBytes(this.class17_0.method_5(this.byte_0, this.byte_1));
						fileStream.Write(bytes, 0, bytes.Length);
						fileStream.Close();
					}
					catch
					{
					}
				}
				if (this.class17_0.dateTime_0 >= this.class18_0.dateTime_0)
				{
					this.class23_0.int_1++;
					this.int_1++;
					if (!this.class18_0.bool_22 || this.int_0 != this.int_1)
					{
						if (this.class18_0.bool_22 || this.int_1 <= 0)
						{
							goto IL_363;
						}
					}
					try
					{
						Class33.smethod_0().method_1((Enum6)3);
						if (Class33.smethod_0().method_6() == (Enum7)2)
						{
							Class33.smethod_0().method_5(Class33.smethod_0().method_0());
						}
						if (Class33.smethod_0().method_6() == (Enum7)1)
						{
							Class33.smethod_0().method_3(Class33.smethod_0().method_0());
						}
						this.timer_0.Dispose();
						if (this.class18_0.bool_28)
						{
							string text = this.class18_0.string_5;
							text = text.Replace(Class15.Class16.string_16, this.class18_0.dateTime_0.ToString());
							text = text.Replace(Class15.Class16.string_17, DateTime.Now.ToString());
							if (this.class18_0.bool_25)
							{
								Class15.Class21.timer_0 = new System.Threading.Timer(new TimerCallback(new Class15.Class21().method_0), null, 90000, 30000);
								try
								{
									Class15.EnableWindow(Process.GetCurrentProcess().MainWindowHandle, false);
								}
								catch
								{
								}
							}
							Class15.ShowMessage(text);
						}
						if (this.class18_0.bool_25)
						{
							try
							{
								Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
				}
				IL_363:;
			}
		}
	}

	private class Class23
	{
		internal System.Threading.Timer timer_0;

		private Class15.Class18 class18_0;

		private Class15.Class17 class17_0;

		internal int int_0;

		internal int int_1;

		internal Class15.Class22 class22_0;

		private Type type_0;

		private byte[] byte_0 = new byte[0];

		private byte[] byte_1 = new byte[0];

		public Class23(Class15.Class18 class18_1, Class15.Class17 class17_1, Type type_1, byte[] byte_2, byte[] byte_3)
		{
			this.class18_0 = class18_1;
			this.class17_0 = class17_1;
			this.type_0 = type_1;
			this.byte_0 = byte_2;
			this.byte_1 = byte_3;
		}

		internal void method_0(object object_0)
		{
			lock (Class15.object_0)
			{
				int int_ = this.class17_0.int_2;
				if (int_ != this.class17_0.int_2 + Math.Abs(DateTime.Now.Subtract(this.class17_0.dateTime_1).Days))
				{
					this.class17_0.int_2 += Math.Abs(DateTime.Now.Subtract(this.class17_0.dateTime_1).Days);
					DateTime dateTime_ = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
					this.class17_0.dateTime_1 = dateTime_;
					Class33.smethod_0().method_21(this.class17_0.int_2);
					try
					{
						string string_ = Class15.Class16.string_0;
						string str = Class15.string_3 + "\\";
						RegistryKey registryKey = Registry.CurrentUser;
						if (Class15.smethod_0())
						{
							registryKey = Registry.LocalMachine;
						}
						RegistryKey registryKey2;
						if (registryKey.OpenSubKey(string_ + str, false) == null)
						{
							registryKey = Registry.CurrentUser;
							if (Class15.smethod_0())
							{
								registryKey = Registry.LocalMachine;
							}
							registryKey2 = registryKey.CreateSubKey(string_ + str);
						}
						registryKey = Registry.CurrentUser;
						if (Class15.smethod_0())
						{
							registryKey = Registry.LocalMachine;
						}
						registryKey2 = registryKey.OpenSubKey(string_ + str, true);
						if (registryKey2 != null)
						{
							registryKey2.SetValue("1", this.class17_0.method_5(this.byte_0, this.byte_1));
							registryKey2.Close();
						}
					}
					catch
					{
					}
					try
					{
						if (Class14.smethod_5(this.type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(this.type_0.Assembly).ToString()))
						{
							Class15.smethod_7(Path.GetDirectoryName(Class14.smethod_5(this.type_0.Assembly).ToString()), Class15.string_2, this.class17_0.method_5(this.byte_0, this.byte_1));
						}
					}
					catch
					{
					}
					try
					{
						FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2, FileMode.Create, FileAccess.ReadWrite);
						byte[] bytes = Encoding.Unicode.GetBytes(this.class17_0.method_5(this.byte_0, this.byte_1));
						fileStream.Write(bytes, 0, bytes.Length);
						fileStream.Close();
					}
					catch
					{
					}
				}
				if (this.class17_0.int_2 > this.class18_0.int_2)
				{
					this.class22_0.int_1++;
					this.int_1++;
					if (!this.class18_0.bool_22 || this.int_0 != this.int_1)
					{
						if (this.class18_0.bool_22 || this.int_1 <= 0)
						{
							goto IL_43F;
						}
					}
					try
					{
						Class33.smethod_0().method_1((Enum6)3);
						if (Class33.smethod_0().method_6() == (Enum7)2)
						{
							Class33.smethod_0().method_5(Class33.smethod_0().method_0());
						}
						if (Class33.smethod_0().method_6() == (Enum7)1)
						{
							Class33.smethod_0().method_3(Class33.smethod_0().method_0());
						}
						this.timer_0.Dispose();
						if (this.class18_0.bool_27)
						{
							int num = this.class18_0.int_2 - this.class17_0.int_2;
							if (num < 0)
							{
								num = 0;
							}
							string text = this.class18_0.string_4;
							text = text.Replace(Class15.Class16.string_12, this.class17_0.int_2.ToString());
							text = text.Replace(Class15.Class16.string_15, this.class18_0.int_2.ToString());
							text = text.Replace(Class15.Class16.string_13, num.ToString());
							if (this.class18_0.bool_25)
							{
								Class15.Class21.timer_0 = new System.Threading.Timer(new TimerCallback(new Class15.Class21().method_0), null, 90000, 30000);
								try
								{
									Class15.EnableWindow(Process.GetCurrentProcess().MainWindowHandle, false);
								}
								catch
								{
								}
							}
							Class15.ShowMessage(text);
						}
						if (this.class18_0.bool_25)
						{
							try
							{
								Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
				}
				IL_43F:;
			}
		}
	}

	private class Class24
	{
		internal System.Threading.Timer timer_0;

		private Class15.Class18 class18_0;

		private Class15.Class17 class17_0;

		private Type type_0;

		private byte[] byte_0 = new byte[0];

		private byte[] byte_1 = new byte[0];

		public Class24(Class15.Class18 class18_1, Class15.Class17 class17_1, Type type_1, byte[] byte_2, byte[] byte_3)
		{
			this.class18_0 = class18_1;
			this.class17_0 = class17_1;
			this.type_0 = type_1;
			this.byte_0 = byte_2;
			this.byte_1 = byte_3;
		}

		internal void method_0(object object_0)
		{
			lock (Class15.object_0)
			{
				this.class17_0.int_1++;
				Class33.smethod_0().method_37(this.class17_0.int_1);
				try
				{
					string string_ = Class15.Class16.string_0;
					string str = Class15.string_3 + "\\";
					RegistryKey registryKey = Registry.CurrentUser;
					if (Class15.smethod_0())
					{
						registryKey = Registry.LocalMachine;
					}
					RegistryKey registryKey2;
					if (registryKey.OpenSubKey(string_ + str, false) == null)
					{
						registryKey = Registry.CurrentUser;
						if (Class15.smethod_0())
						{
							registryKey = Registry.LocalMachine;
						}
						registryKey2 = registryKey.CreateSubKey(string_ + str);
					}
					registryKey = Registry.CurrentUser;
					if (Class15.smethod_0())
					{
						registryKey = Registry.LocalMachine;
					}
					registryKey2 = registryKey.OpenSubKey(string_ + str, true);
					if (registryKey2 != null)
					{
						registryKey2.SetValue("1", this.class17_0.method_5(this.byte_0, this.byte_1));
						registryKey2.Close();
					}
				}
				catch
				{
				}
				try
				{
					if (Class14.smethod_5(this.type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(this.type_0.Assembly).ToString()))
					{
						Class15.smethod_7(Path.GetDirectoryName(Class14.smethod_5(this.type_0.Assembly).ToString()), Class15.string_2, this.class17_0.method_5(this.byte_0, this.byte_1));
					}
				}
				catch
				{
				}
				try
				{
					FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2, FileMode.Create, FileAccess.ReadWrite);
					byte[] bytes = Encoding.Unicode.GetBytes(this.class17_0.method_5(this.byte_0, this.byte_1));
					fileStream.Write(bytes, 0, bytes.Length);
					fileStream.Close();
				}
				catch
				{
				}
				if (this.class17_0.int_1 >= this.class18_0.int_5)
				{
					Class33.smethod_0().method_1((Enum6)3);
					if (Class33.smethod_0().method_6() == (Enum7)2)
					{
						Class33.smethod_0().method_5(Class33.smethod_0().method_0());
					}
					if (Class33.smethod_0().method_6() == (Enum7)1)
					{
						Class33.smethod_0().method_3(Class33.smethod_0().method_0());
					}
					this.timer_0.Dispose();
					if (this.class18_0.bool_33)
					{
						int num = this.class18_0.int_5 - this.class17_0.int_1;
						if (num < 0)
						{
							num = 0;
						}
						string text = this.class18_0.string_9;
						text = text.Replace(Class15.Class16.string_22, this.class17_0.int_1.ToString());
						text = text.Replace(Class15.Class16.string_23, this.class18_0.int_5.ToString());
						text = text.Replace(Class15.Class16.string_14, num.ToString());
						if (this.class18_0.bool_25)
						{
							Class15.Class21.timer_0 = new System.Threading.Timer(new TimerCallback(new Class15.Class21().method_0), null, 90000, 30000);
							try
							{
								Class15.EnableWindow(Process.GetCurrentProcess().MainWindowHandle, false);
							}
							catch
							{
							}
						}
						Class15.ShowMessage(text);
					}
					if (this.class18_0.bool_25)
					{
						try
						{
							Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
						}
						catch
						{
						}
					}
				}
			}
		}
	}

	[ComVisible(true)]
	internal struct Struct1
	{
		internal object object_0;

		internal IntPtr intptr_0;

		public Struct1(object object_1, IntPtr intptr_1)
		{
			this.object_0 = object_1;
			this.intptr_0 = intptr_1;
		}

		public object method_0()
		{
			return this.object_0;
		}

		public IntPtr method_1()
		{
			return this.intptr_0;
		}

		public static explicit operator IntPtr(Class15.Struct1 struct1_0)
		{
			return struct1_0.intptr_0;
		}

		public static IntPtr smethod_0(Class15.Struct1 struct1_0)
		{
			return struct1_0.intptr_0;
		}
	}

	[LicenseProvider(typeof(Class15))]
	private class Class25
	{
		private void method_0()
		{
			LicenseManager.Validate(typeof(Class15));
		}
	}

	private class Class26 : License
	{
		private object object_0;

		private string string_0;

		public override string LicenseKey
		{
			get
			{
				return this.string_0;
			}
		}

		public Class26(object object_1, string string_1)
		{
			this.object_0 = object_1;
			this.string_0 = string_1;
		}

		public override void Dispose()
		{
		}
	}

	internal struct Struct2
	{
		public IntPtr intptr_0;

		public int int_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
		public string string_1;

		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] byte_0;

		public int int_1;

		public uint uint_1;

		public uint uint_2;

		public IntPtr intptr_1;

		public Class15.Struct3 struct3_0;

		public Class15.Struct3 struct3_1;

		public Class15.Struct3 struct3_2;

		public bool bool_0;

		public Class15.Struct3 struct3_3;

		public Class15.Struct3 struct3_4;

		public int int_2;

		public int int_3;
	}

	internal struct Struct3
	{
		public IntPtr intptr_0;

		public Class15.Struct4 struct4_0;

		public Class15.Struct4 struct4_1;

		public int int_0;
	}

	internal struct Struct4
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string string_0;
	}

	internal class Class27 : RSA
	{
		internal enum Enum4
		{

		}

		private const int int_0 = 1;

		private const int int_1 = 2;

		private static byte[] byte_0;

		private static byte[] byte_1;

		private int int_2;

		private Class15.Class28 class28_0;

		private Class15.Class28 class28_1;

		private Class15.Class28 class28_2;

		private Class15.Class28 class28_3;

		private Class15.Class28 class28_4;

		private Class15.Class28 class28_5;

		private Class15.Class28 class28_6;

		private Class15.Class28 class28_7;

		public override string KeyExchangeAlgorithm
		{
			get
			{
				return "RSA-PKCS1-KeyEx";
			}
		}

		public override string SignatureAlgorithm
		{
			get
			{
				return "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
			}
		}

		public override int KeySize
		{
			get
			{
				return this.int_2 * 8;
			}
			set
			{
				throw new ArgumentException();
			}
		}

		public Class27()
		{
			this.int_2 = 256;
		}

		public Class27(int int_3)
		{
			this.int_2 = int_3 / 8;
		}

		public override void FromXmlString(string xmlString)
		{
			StringReader input = new StringReader(xmlString);
			XmlTextReader xmlTextReader = new XmlTextReader(input);
			this.class28_0 = (this.class28_1 = (this.class28_2 = (this.class28_3 = (this.class28_4 = (this.class28_5 = (this.class28_6 = (this.class28_7 = null)))))));
			while (true)
			{
				XmlNodeType xmlNodeType = xmlTextReader.MoveToContent();
				XmlNodeType xmlNodeType2 = xmlNodeType;
				switch (xmlNodeType2)
				{
				case XmlNodeType.None:
					return;
				case XmlNodeType.Element:
				{
					string name = xmlTextReader.Name;
					if (!this.method_15(xmlTextReader, name, "Modulus", ref this.class28_0) && !this.method_15(xmlTextReader, name, "Exponent", ref this.class28_1) && !this.method_15(xmlTextReader, name, "P", ref this.class28_2) && !this.method_15(xmlTextReader, name, "Q", ref this.class28_3) && !this.method_15(xmlTextReader, name, "DP", ref this.class28_4) && !this.method_15(xmlTextReader, name, "DQ", ref this.class28_5) && !this.method_15(xmlTextReader, name, "InverseQ", ref this.class28_6) && !this.method_15(xmlTextReader, name, "D", ref this.class28_7))
					{
						xmlTextReader.ReadString();
					}
					break;
				}
				default:
					if (xmlNodeType2 != XmlNodeType.EndElement)
					{
						goto Block_9;
					}
					xmlTextReader.ReadEndElement();
					break;
				}
			}
			Block_9:
			throw new ArgumentException();
		}

		public override void ImportParameters(RSAParameters parameters)
		{
			this.class28_0 = new Class15.Class28(parameters.Modulus);
			this.class28_1 = new Class15.Class28(parameters.Exponent);
			this.class28_2 = ((!object.ReferenceEquals(parameters.P, null)) ? new Class15.Class28(parameters.P) : null);
			this.class28_3 = ((!object.ReferenceEquals(parameters.Q, null)) ? new Class15.Class28(parameters.Q) : null);
			this.class28_4 = ((!object.ReferenceEquals(parameters.DP, null)) ? new Class15.Class28(parameters.DP) : null);
			this.class28_5 = ((!object.ReferenceEquals(parameters.DQ, null)) ? new Class15.Class28(parameters.DQ) : null);
			this.class28_6 = ((!object.ReferenceEquals(parameters.InverseQ, null)) ? new Class15.Class28(parameters.InverseQ) : null);
			this.class28_7 = ((!object.ReferenceEquals(parameters.D, null)) ? new Class15.Class28(parameters.D) : null);
		}

		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			RSAParameters result = default(RSAParameters);
			result.Modulus = this.class28_0.method_2();
			result.Exponent = this.class28_1.method_2();
			if (includePrivateParameters)
			{
				result.P = this.class28_2.method_2();
				result.Q = this.class28_3.method_2();
				result.DP = this.class28_4.method_2();
				result.DQ = this.class28_5.method_2();
				result.InverseQ = this.class28_6.method_2();
				result.D = this.class28_7.method_2();
			}
			return result;
		}

		public byte[] method_0(byte[] byte_2)
		{
			if (byte_2.Length != this.int_2)
			{
				throw new ArgumentException("input.Length does not match keylen");
			}
			if (object.ReferenceEquals(this.class28_0, null))
			{
				throw new ArgumentException("no key set!");
			}
			Class15.Class28 @class = new Class15.Class28(byte_2);
			if (@class >= this.class28_0)
			{
				throw new ArgumentException("input exceeds modulus");
			}
			@class = @class.method_7(this.class28_1, this.class28_0);
			byte[] byte_3 = @class.method_2();
			return this.method_13(byte_3, this.int_2);
		}

		public byte[] method_1(byte[] byte_2)
		{
			if (byte_2.Length != this.int_2)
			{
				throw new ArgumentException("input.Length does not match keylen");
			}
			if (object.ReferenceEquals(this.class28_7, null))
			{
				throw new ArgumentException("no private key set!");
			}
			Class15.Class28 @class = new Class15.Class28(byte_2);
			if (@class >= this.class28_0)
			{
				throw new ArgumentException("input exceeds modulus");
			}
			@class = @class.method_7(this.class28_7, this.class28_0);
			byte[] byte_3 = @class.method_2();
			return this.method_13(byte_3, this.int_2);
		}

		public bool method_2()
		{
			Class15.Class28 @class = this.class28_2 * this.class28_3;
			if (@class != this.class28_0)
			{
				return false;
			}
			Class15.Class28 class2 = this.class28_2 - 1;
			Class15.Class28 class3 = this.class28_3 - 1;
			Class15.Class28 class4 = class2 * class3;
			Class15.Class28 class5 = this.class28_1.method_6(class4);
			return !(class5 != 1u);
		}

		public byte[] method_3(byte[] byte_2, bool bool_0)
		{
			if (bool_0)
			{
				throw new ArgumentException("OAEP padding not supported, sorry");
			}
			int num = byte_2.Length;
			int num2 = this.int_2 - 3 - num;
			if (num2 < 8)
			{
				throw new ArgumentException("input too long");
			}
			byte[] array = new byte[this.int_2];
			array[0] = 0;
			array[1] = 2;
			byte[] array2 = new byte[num2];
			RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			rNGCryptoServiceProvider.GetBytes(array2);
			for (int i = 0; i < num2; i++)
			{
				if (array2[i] == 0)
				{
					array2[i] = (byte)i;
				}
				if ((byte)i == 0)
				{
					array2[i] = 1;
				}
			}
			Array.Copy(array2, 0, array, 2, num2);
			array[num2 + 2] = 0;
			Array.Copy(byte_2, 0, array, num2 + 3, num);
			return this.method_0(array);
		}

		public byte[] method_4(byte[] byte_2, bool bool_0)
		{
			if (bool_0)
			{
				throw new ArgumentException("OAEP padding not supported, sorry");
			}
			byte[] array = this.method_1(byte_2);
			if (array[0] == 0)
			{
				if (array[1] == 2)
				{
					int num = array.Length;
					for (int i = 2; i < num - 1; i++)
					{
						if (array[i] == 0)
						{
							i++;
							int num2 = num - i;
							byte[] array2 = new byte[num2];
							Array.Copy(array, i, array2, 0, num2);
							return array2;
						}
					}
					throw new ArgumentException("invalid padding");
				}
			}
			throw new ArgumentException("invalid signature bytes");
		}

		public Class15.Class27.Enum4 method_5(string string_0)
		{
			Class15.Class27.Enum4 result;
			if (string.Compare(string_0, CryptoConfig.MapNameToOID("MD5"), true) == 0)
			{
				result = (Class15.Class27.Enum4)5;
			}
			else
			{
				if (string.Compare(string_0, CryptoConfig.MapNameToOID("SHA1"), true) != 0)
				{
					throw new ArgumentException("unknown hash_algorithm_oid");
				}
				result = (Class15.Class27.Enum4)1;
			}
			return result;
		}

		public byte[] method_6(byte[] byte_2, string string_0)
		{
			Class15.Class27.Enum4 enum4_ = this.method_5(string_0);
			return this.method_7(byte_2, enum4_);
		}

		public byte[] method_7(byte[] byte_2, Class15.Class27.Enum4 enum4_0)
		{
			int num = byte_2.Length;
			int num2 = 0;
			switch (enum4_0)
			{
			case (Class15.Class27.Enum4)0:
				num2 = this.int_2 - 3 - num;
				break;
			case (Class15.Class27.Enum4)1:
				if (num != 20)
				{
					throw new ArgumentException("SHA1 hashes must be 20 bytes long");
				}
				num2 = this.int_2 - 3 - 35;
				break;
			case (Class15.Class27.Enum4)2:
			case (Class15.Class27.Enum4)4:
			case (Class15.Class27.Enum4)5:
				if (num != 16)
				{
					throw new ArgumentException("MDx hashes must be 16 bytes long");
				}
				num2 = this.int_2 - 3 - 34;
				break;
			}
			if (num2 < 8)
			{
				throw new ArgumentException("input too long");
			}
			byte[] array = new byte[this.int_2];
			array[0] = 0;
			array[1] = 1;
			for (int i = 0; i < num2; i++)
			{
				array[i + 2] = 255;
			}
			array[num2 + 2] = 0;
			switch (enum4_0)
			{
			case (Class15.Class27.Enum4)0:
				Array.Copy(byte_2, 0, array, num2 + 3, num);
				break;
			case (Class15.Class27.Enum4)1:
				Array.Copy(Class15.Class27.byte_1, 0, array, num2 + 3, 15);
				Array.Copy(byte_2, 0, array, num2 + 3 + 15, num);
				break;
			case (Class15.Class27.Enum4)2:
			case (Class15.Class27.Enum4)4:
			case (Class15.Class27.Enum4)5:
				Array.Copy(Class15.Class27.byte_0, 0, array, num2 + 3, 18);
				array[num2 + 3 + 13] = (byte)enum4_0;
				Array.Copy(byte_2, 0, array, num2 + 3 + 18, num);
				break;
			}
			return this.method_1(array);
		}

		public bool method_8(byte[] byte_2, string string_0, byte[] byte_3)
		{
			Class15.Class27.Enum4 enum4_ = this.method_5(string_0);
			return this.method_9(byte_2, byte_3, enum4_);
		}

		public bool method_9(byte[] byte_2, byte[] byte_3, Class15.Class27.Enum4 enum4_0)
		{
			int num = byte_3.Length;
			if (num != this.int_2)
			{
				return false;
			}
			byte[] array = this.method_0(byte_3);
			if (array[0] == 0)
			{
				if (array[1] == 1)
				{
					int num2 = array.Length;
					int i = 2;
					while (i < num2 - 1)
					{
						byte b = array[i];
						if (b != 0)
						{
							if (b != 255)
							{
								return false;
							}
							i++;
						}
						else
						{
							i++;
							int num3 = num2 - i;
							if (num3 == 34)
							{
								if (array[i + 13] != (byte)enum4_0)
								{
									return false;
								}
								array[i + 13] = 0;
								return this.method_12(array, i, Class15.Class27.byte_0, 0, 18) && this.method_12(array, i + 18, byte_2, 0, 16);
							}
							else
							{
								if (num3 == 35 && enum4_0 == (Class15.Class27.Enum4)1)
								{
									return this.method_12(array, i, Class15.Class27.byte_1, 0, 15) && this.method_12(array, i + 15, byte_2, 0, 20);
								}
								return num3 == byte_2.Length && enum4_0 == (Class15.Class27.Enum4)0 && this.method_12(array, i, byte_2, 0, num3);
							}
						}
					}
					return false;
				}
			}
			return false;
		}

		public byte[] method_10(byte[] byte_2, HashAlgorithm hashAlgorithm_0)
		{
			Class15.Class27.Enum4 enum4_ = this.method_16(hashAlgorithm_0);
			byte[] byte_3 = hashAlgorithm_0.ComputeHash(byte_2);
			return this.method_7(byte_3, enum4_);
		}

		public bool method_11(byte[] byte_2, HashAlgorithm hashAlgorithm_0, byte[] byte_3)
		{
			Class15.Class27.Enum4 enum4_ = this.method_16(hashAlgorithm_0);
			byte[] byte_4 = hashAlgorithm_0.ComputeHash(byte_2);
			return this.method_9(byte_4, byte_3, enum4_);
		}

		public override byte[] EncryptValue(byte[] rgb)
		{
			return this.method_0(rgb);
		}

		public override byte[] DecryptValue(byte[] rgb)
		{
			return this.method_1(rgb);
		}

		protected override void Dispose(bool disposing)
		{
			this.class28_0 = (this.class28_1 = (this.class28_2 = (this.class28_3 = (this.class28_4 = (this.class28_5 = (this.class28_6 = (this.class28_7 = null)))))));
		}

		private bool method_12(byte[] byte_2, int int_3, byte[] byte_3, int int_4, int int_5)
		{
			for (int i = 0; i < int_5; i++)
			{
				if (byte_2[i + int_3] != byte_3[i + int_4])
				{
					return false;
				}
			}
			return true;
		}

		private byte[] method_13(byte[] byte_2, int int_3)
		{
			int num = byte_2.Length;
			if (num >= int_3)
			{
				return byte_2;
			}
			byte[] array = new byte[int_3];
			int num2 = int_3 - num;
			for (int i = 0; i < num2; i++)
			{
				array[i] = 0;
			}
			Array.Copy(byte_2, 0, array, num2, num);
			return array;
		}

		private string method_14(Class15.Class28 class28_8)
		{
			byte[] inArray = class28_8.method_2();
			return Convert.ToBase64String(inArray);
		}

		private bool method_15(XmlReader xmlReader_0, string string_0, string string_1, ref Class15.Class28 class28_8)
		{
			if (string.Compare(string_0, string_1, true) != 0)
			{
				return false;
			}
			string s = xmlReader_0.ReadString();
			byte[] array = Convert.FromBase64String(s);
			Class15.Class28 @class = new Class15.Class28(array);
			class28_8 = @class;
			return true;
		}

		private Class15.Class27.Enum4 method_16(HashAlgorithm hashAlgorithm_0)
		{
			Type type = hashAlgorithm_0.GetType();
			if (object.ReferenceEquals(type, typeof(MD5CryptoServiceProvider)))
			{
				return (Class15.Class27.Enum4)5;
			}
			if (!object.ReferenceEquals(type, typeof(SHA1CryptoServiceProvider)))
			{
				throw new ArgumentException("unknown HashAlgorithm");
			}
			return (Class15.Class27.Enum4)1;
		}

		static Class27()
		{
			Class15.Class27.byte_0 = new byte[]
			{
				48,
				32,
				48,
				12,
				6,
				8,
				42,
				134,
				72,
				134,
				247,
				13,
				2,
				0,
				5,
				0,
				4,
				16
			};
			Class15.Class27.byte_1 = new byte[]
			{
				48,
				33,
				48,
				9,
				6,
				5,
				43,
				14,
				3,
				2,
				26,
				5,
				0,
				4,
				20
			};
		}
	}

	private class Class28
	{
		internal enum Enum5
		{

		}

		private sealed class Class29
		{
			private Class15.Class28 class28_0;

			private Class15.Class28 class28_1;

			public Class29(Class15.Class28 class28_2)
			{
				this.class28_0 = class28_2;
				uint num = this.class28_0.uint_0 << 1;
				this.class28_1 = new Class15.Class28((Class15.Class28.Enum5)1, num + 1u);
				this.class28_1.uint_1[(int)((UIntPtr)num)] = 1u;
				this.class28_1 /= this.class28_0;
			}

			public void method_0(Class15.Class28 class28_2)
			{
				Class15.Class28 @class = this.class28_0;
				uint uint_ = @class.uint_0;
				uint num = uint_ + 1u;
				uint num2 = uint_ - 1u;
				if (class28_2.uint_0 < uint_)
				{
					return;
				}
				if ((long)class28_2.uint_1.Length < (long)((ulong)class28_2.uint_0))
				{
					throw new IndexOutOfRangeException("x out of range");
				}
				Class15.Class28 class2 = new Class15.Class28((Class15.Class28.Enum5)1, class28_2.uint_0 - num2 + this.class28_1.uint_0);
				Class15.Class28.Class30.smethod_13(class28_2.uint_1, num2, class28_2.uint_0 - num2, this.class28_1.uint_1, 0u, this.class28_1.uint_0, class2.uint_1, 0u);
				uint uint_2 = (class28_2.uint_0 > num) ? num : class28_2.uint_0;
				class28_2.uint_0 = uint_2;
				class28_2.method_5();
				Class15.Class28 class3 = new Class15.Class28((Class15.Class28.Enum5)1, num);
				Class15.Class28.Class30.smethod_14(class2.uint_1, (int)num, (int)(class2.uint_0 - num), @class.uint_1, 0, (int)@class.uint_0, class3.uint_1, 0, (int)num);
				class3.method_5();
				if (class3 <= class28_2)
				{
					Class15.Class28.Class30.smethod_2(class28_2, class3);
				}
				else
				{
					Class15.Class28 class4 = new Class15.Class28((Class15.Class28.Enum5)1, num + 1u);
					class4.uint_1[(int)((UIntPtr)num)] = 1u;
					Class15.Class28.Class30.smethod_2(class4, class3);
					Class15.Class28.Class30.smethod_3(class28_2, class4);
				}
				while (class28_2 >= @class)
				{
					Class15.Class28.Class30.smethod_2(class28_2, @class);
				}
			}

			public Class15.Class28 method_1(Class15.Class28 class28_2, Class15.Class28 class28_3)
			{
				if (!(class28_2 == 0u) && !(class28_3 == 0u))
				{
					if (class28_2 > this.class28_0)
					{
						class28_2 %= this.class28_0;
					}
					if (class28_3 > this.class28_0)
					{
						class28_3 %= this.class28_0;
					}
					Class15.Class28 @class = class28_2 * class28_3;
					this.method_0(@class);
					return @class;
				}
				return 0;
			}

			public Class15.Class28 method_2(Class15.Class28 class28_2, Class15.Class28 class28_3)
			{
				Class15.Class28.Enum5 @enum = Class15.Class28.Class30.smethod_4(class28_2, class28_3);
				Class15.Class28 @class;
				switch (@enum)
				{
				case (Class15.Class28.Enum5)(-1):
					@class = class28_3 - class28_2;
					break;
				case (Class15.Class28.Enum5)0:
					return 0;
				case (Class15.Class28.Enum5)1:
					@class = class28_2 - class28_3;
					break;
				default:
					throw new Exception();
				}
				if (@class >= this.class28_0)
				{
					if (@class.uint_0 >= this.class28_0.uint_0 << 1)
					{
						@class %= this.class28_0;
					}
					else
					{
						this.method_0(@class);
					}
				}
				if (@enum == (Class15.Class28.Enum5)(-1))
				{
					@class = this.class28_0 - @class;
				}
				return @class;
			}

			public Class15.Class28 method_3(Class15.Class28 class28_2, Class15.Class28 class28_3)
			{
				Class15.Class28 @class = new Class15.Class28(1u);
				if (class28_3 == 0u)
				{
					return @class;
				}
				Class15.Class28 class2 = class28_2;
				if (class28_3.method_1(0))
				{
					@class = class28_2;
				}
				for (int i = 1; i < class28_3.method_0(); i++)
				{
					class2 = this.method_1(class2, class2);
					if (class28_3.method_1(i))
					{
						@class = this.method_1(class2, @class);
					}
				}
				return @class;
			}

			public Class15.Class28 method_4(uint uint_0, Class15.Class28 class28_2)
			{
				return this.method_3(new Class15.Class28(uint_0), class28_2);
			}
		}

		private sealed class Class30
		{
			public static Class15.Class28 smethod_0(Class15.Class28 class28_0, Class15.Class28 class28_1)
			{
				uint num = 0u;
				uint[] uint_;
				uint uint_2;
				uint[] uint_3;
				uint uint_4;
				if (class28_0.uint_0 < class28_1.uint_0)
				{
					uint_ = class28_1.uint_1;
					uint_2 = class28_1.uint_0;
					uint_3 = class28_0.uint_1;
					uint_4 = class28_0.uint_0;
				}
				else
				{
					uint_ = class28_0.uint_1;
					uint_2 = class28_0.uint_0;
					uint_3 = class28_1.uint_1;
					uint_4 = class28_1.uint_0;
				}
				Class15.Class28 @class = new Class15.Class28((Class15.Class28.Enum5)1, uint_2 + 1u);
				uint[] uint_5 = @class.uint_1;
				ulong num2 = 0uL;
				do
				{
					num2 = (ulong)uint_[(int)((UIntPtr)num)] + (ulong)uint_3[(int)((UIntPtr)num)] + num2;
					uint_5[(int)((UIntPtr)num)] = (uint)num2;
					num2 >>= 32;
				}
				while ((num += 1u) < uint_4);
				bool flag;
				if (flag = (num2 != 0uL))
				{
					if (num < uint_2)
					{
						do
						{
							flag = ((uint_5[(int)((UIntPtr)num)] = uint_[(int)((UIntPtr)num)] + 1u) == 0u);
						}
						while ((num += 1u) < uint_2 && flag);
					}
					if (flag)
					{
						uint_5[(int)((UIntPtr)num)] = 1u;
						@class.uint_0 = num + 1u;
						return @class;
					}
				}
				if (num < uint_2)
				{
					do
					{
						uint_5[(int)((UIntPtr)num)] = uint_[(int)((UIntPtr)num)];
					}
					while ((num += 1u) < uint_2);
				}
				@class.method_5();
				return @class;
			}

			public static Class15.Class28 smethod_1(Class15.Class28 class28_0, Class15.Class28 class28_1)
			{
				Class15.Class28 @class = new Class15.Class28((Class15.Class28.Enum5)1, class28_0.uint_0);
				uint[] uint_ = @class.uint_1;
				uint[] uint_2 = class28_0.uint_1;
				uint[] uint_3 = class28_1.uint_1;
				uint num = 0u;
				uint num2 = 0u;
				do
				{
					uint num3 = uint_3[(int)((UIntPtr)num)];
					if ((num3 += num2) < num2 | (uint_[(int)((UIntPtr)num)] = uint_2[(int)((UIntPtr)num)] - num3) > ~num3)
					{
						num2 = 1u;
					}
					else
					{
						num2 = 0u;
					}
				}
				while ((num += 1u) < class28_1.uint_0);
				if (num != class28_0.uint_0)
				{
					if (num2 == 1u)
					{
						do
						{
							uint_[(int)((UIntPtr)num)] = uint_2[(int)((UIntPtr)num)] - 1u;
						}
						while (uint_2[(int)((UIntPtr)(num++))] == 0u && num < class28_0.uint_0);
						if (num == class28_0.uint_0)
						{
							goto IL_C8;
						}
					}
					do
					{
						uint_[(int)((UIntPtr)num)] = uint_2[(int)((UIntPtr)num)];
					}
					while ((num += 1u) < class28_0.uint_0);
				}
				IL_C8:
				@class.method_5();
				return @class;
			}

			public static void smethod_2(Class15.Class28 class28_0, Class15.Class28 class28_1)
			{
				uint[] uint_ = class28_0.uint_1;
				uint[] uint_2 = class28_1.uint_1;
				uint num = 0u;
				uint num2 = 0u;
				do
				{
					uint num3 = uint_2[(int)((UIntPtr)num)];
					if ((num3 += num2) < num2 | (uint_[(int)((UIntPtr)num)] -= num3) > ~num3)
					{
						num2 = 1u;
					}
					else
					{
						num2 = 0u;
					}
				}
				while ((num += 1u) < class28_1.uint_0);
				if (num != class28_0.uint_0 && num2 == 1u)
				{
					do
					{
						uint_[(int)((UIntPtr)num)] -= 1u;
					}
					while (uint_[(int)((UIntPtr)(num++))] == 0u && num < class28_0.uint_0);
				}
				while (class28_0.uint_0 > 0u && class28_0.uint_1[(int)((UIntPtr)(class28_0.uint_0 - 1u))] == 0u)
				{
					class28_0.uint_0 -= 1u;
				}
				if (class28_0.uint_0 == 0u)
				{
					class28_0.uint_0 += 1u;
				}
			}

			public static void smethod_3(Class15.Class28 class28_0, Class15.Class28 class28_1)
			{
				uint num = 0u;
				bool flag = false;
				uint[] uint_;
				uint uint_2;
				uint[] uint_3;
				uint uint_4;
				if (class28_0.uint_0 < class28_1.uint_0)
				{
					flag = true;
					uint_ = class28_1.uint_1;
					uint_2 = class28_1.uint_0;
					uint_3 = class28_0.uint_1;
					uint_4 = class28_0.uint_0;
				}
				else
				{
					uint_ = class28_0.uint_1;
					uint_2 = class28_0.uint_0;
					uint_3 = class28_1.uint_1;
					uint_4 = class28_1.uint_0;
				}
				uint[] uint_5 = class28_0.uint_1;
				ulong num2 = 0uL;
				do
				{
					num2 += (ulong)uint_[(int)((UIntPtr)num)] + (ulong)uint_3[(int)((UIntPtr)num)];
					uint_5[(int)((UIntPtr)num)] = (uint)num2;
					num2 >>= 32;
				}
				while ((num += 1u) < uint_4);
				bool flag2;
				if (flag2 = (num2 != 0uL))
				{
					if (num < uint_2)
					{
						do
						{
							flag2 = ((uint_5[(int)((UIntPtr)num)] = uint_[(int)((UIntPtr)num)] + 1u) == 0u);
						}
						while ((num += 1u) < uint_2 && flag2);
					}
					if (flag2)
					{
						uint_5[(int)((UIntPtr)num)] = 1u;
						class28_0.uint_0 = num + 1u;
						return;
					}
				}
				if (flag && num < uint_2 - 1u)
				{
					do
					{
						uint_5[(int)((UIntPtr)num)] = uint_[(int)((UIntPtr)num)];
					}
					while ((num += 1u) < uint_2);
				}
				class28_0.uint_0 = uint_2 + 1u;
				class28_0.method_5();
			}

			public static Class15.Class28.Enum5 smethod_4(Class15.Class28 class28_0, Class15.Class28 class28_1)
			{
				uint num = class28_0.uint_0;
				uint num2 = class28_1.uint_0;
				while (num > 0u && class28_0.uint_1[(int)((UIntPtr)(num - 1u))] == 0u)
				{
					num -= 1u;
				}
				while (num2 > 0u && class28_1.uint_1[(int)((UIntPtr)(num2 - 1u))] == 0u)
				{
					num2 -= 1u;
				}
				if (num == 0u && num2 == 0u)
				{
					return (Class15.Class28.Enum5)0;
				}
				if (num < num2)
				{
					return (Class15.Class28.Enum5)(-1);
				}
				if (num > num2)
				{
					return (Class15.Class28.Enum5)1;
				}
				uint num3;
				for (num3 = num - 1u; num3 != 0u; num3 -= 1u)
				{
					if (class28_0.uint_1[(int)((UIntPtr)num3)] != class28_1.uint_1[(int)((UIntPtr)num3)])
					{
						break;
					}
				}
				if (class28_0.uint_1[(int)((UIntPtr)num3)] < class28_1.uint_1[(int)((UIntPtr)num3)])
				{
					return (Class15.Class28.Enum5)(-1);
				}
				if (class28_0.uint_1[(int)((UIntPtr)num3)] > class28_1.uint_1[(int)((UIntPtr)num3)])
				{
					return (Class15.Class28.Enum5)1;
				}
				return (Class15.Class28.Enum5)0;
			}

			public static uint smethod_5(Class15.Class28 class28_0, uint uint_0)
			{
				ulong num = 0uL;
				uint uint_ = class28_0.uint_0;
				while (uint_-- > 0u)
				{
					num <<= 32;
					num |= (ulong)class28_0.uint_1[(int)((UIntPtr)uint_)];
					class28_0.uint_1[(int)((UIntPtr)uint_)] = (uint)(num / (ulong)uint_0);
					num %= (ulong)uint_0;
				}
				class28_0.method_5();
				return (uint)num;
			}

			public static uint smethod_6(Class15.Class28 class28_0, uint uint_0)
			{
				ulong num = 0uL;
				uint uint_ = class28_0.uint_0;
				while (uint_-- > 0u)
				{
					num <<= 32;
					num |= (ulong)class28_0.uint_1[(int)((UIntPtr)uint_)];
					num %= (ulong)uint_0;
				}
				return (uint)num;
			}

			public static Class15.Class28 smethod_7(Class15.Class28 class28_0, uint uint_0)
			{
				Class15.Class28 @class = new Class15.Class28((Class15.Class28.Enum5)1, class28_0.uint_0);
				ulong num = 0uL;
				uint uint_ = class28_0.uint_0;
				while (uint_-- > 0u)
				{
					num <<= 32;
					num |= (ulong)class28_0.uint_1[(int)((UIntPtr)uint_)];
					@class.uint_1[(int)((UIntPtr)uint_)] = (uint)(num / (ulong)uint_0);
					num %= (ulong)uint_0;
				}
				@class.method_5();
				return @class;
			}

			public static Class15.Class28[] smethod_8(Class15.Class28 class28_0, uint uint_0)
			{
				Class15.Class28 @class = new Class15.Class28((Class15.Class28.Enum5)1, class28_0.uint_0);
				ulong num = 0uL;
				uint uint_ = class28_0.uint_0;
				while (uint_-- > 0u)
				{
					num <<= 32;
					num |= (ulong)class28_0.uint_1[(int)((UIntPtr)uint_)];
					@class.uint_1[(int)((UIntPtr)uint_)] = (uint)(num / (ulong)uint_0);
					num %= (ulong)uint_0;
				}
				@class.method_5();
				Class15.Class28 class2 = (uint)num;
				return new Class15.Class28[]
				{
					@class,
					class2
				};
			}

			public static Class15.Class28[] smethod_9(Class15.Class28 class28_0, Class15.Class28 class28_1)
			{
				if (Class15.Class28.Class30.smethod_4(class28_0, class28_1) == (Class15.Class28.Enum5)(-1))
				{
					return new Class15.Class28[]
					{
						0,
						new Class15.Class28(class28_0)
					};
				}
				class28_0.method_5();
				class28_1.method_5();
				if (class28_1.uint_0 == 1u)
				{
					return Class15.Class28.Class30.smethod_8(class28_0, class28_1.uint_1[0]);
				}
				uint num = class28_0.uint_0 + 1u;
				int num2 = (int)(class28_1.uint_0 + 1u);
				uint num3 = 2147483648u;
				uint num4 = class28_1.uint_1[(int)((UIntPtr)(class28_1.uint_0 - 1u))];
				int num5 = 0;
				int num6 = (int)(class28_0.uint_0 - class28_1.uint_0);
				while (num3 != 0u && (num4 & num3) == 0u)
				{
					num5++;
					num3 >>= 1;
				}
				Class15.Class28 @class = new Class15.Class28((Class15.Class28.Enum5)1, class28_0.uint_0 - class28_1.uint_0 + 1u);
				Class15.Class28 class2 = class28_0 << num5;
				uint[] uint_ = class2.uint_1;
				class28_1 <<= num5;
				int i = (int)(num - class28_1.uint_0);
				int num7 = (int)(num - 1u);
				uint num8 = class28_1.uint_1[(int)((UIntPtr)(class28_1.uint_0 - 1u))];
				ulong num9 = (ulong)class28_1.uint_1[(int)((UIntPtr)(class28_1.uint_0 - 2u))];
				while (i > 0)
				{
					ulong num10 = ((ulong)uint_[num7] << 32) + (ulong)uint_[num7 - 1];
					ulong num11 = num10 / (ulong)num8;
					ulong num12 = num10 % (ulong)num8;
					do
					{
						if (num11 != 4294967296uL)
						{
							if (num11 * num9 <= (num12 << 32) + (ulong)uint_[num7 - 2])
							{
								break;
							}
						}
						num11 -= 1uL;
						num12 += (ulong)num8;
					}
					while (num12 < 4294967296uL);
					IL_17B:
					uint num13 = 0u;
					int num14 = num7 - num2 + 1;
					ulong num15 = 0uL;
					uint num16 = (uint)num11;
					do
					{
						num15 += (ulong)class28_1.uint_1[(int)((UIntPtr)num13)] * (ulong)num16;
						uint num17 = uint_[num14];
						uint_[num14] -= (uint)num15;
						num15 >>= 32;
						if (uint_[num14] > num17)
						{
							num15 += 1uL;
						}
						num13 += 1u;
						num14++;
					}
					while ((ulong)num13 < (ulong)((long)num2));
					num14 = num7 - num2 + 1;
					num13 = 0u;
					if (num15 != 0uL)
					{
						num16 -= 1u;
						ulong num18 = 0uL;
						do
						{
							num18 = (ulong)uint_[num14] + (ulong)class28_1.uint_1[(int)((UIntPtr)num13)] + num18;
							uint_[num14] = (uint)num18;
							num18 >>= 32;
							num13 += 1u;
							num14++;
						}
						while ((ulong)num13 < (ulong)((long)num2));
					}
					@class.uint_1[num6--] = num16;
					num7--;
					i--;
					continue;
					goto IL_17B;
				}
				@class.method_5();
				class2.method_5();
				Class15.Class28[] array = new Class15.Class28[]
				{
					@class,
					class2
				};
				if (num5 != 0)
				{
					Class15.Class28[] array2;
					(array2 = array)[1] = array2[1] >> num5;
				}
				return array;
			}

			public static Class15.Class28 smethod_10(Class15.Class28 class28_0, int int_0)
			{
				if (int_0 == 0)
				{
					return new Class15.Class28(class28_0, class28_0.uint_0 + 1u);
				}
				int num = int_0 >> 5;
				int_0 &= 31;
				Class15.Class28 @class = new Class15.Class28((Class15.Class28.Enum5)1, class28_0.uint_0 + 1u + (uint)num);
				uint num2 = 0u;
				uint uint_ = class28_0.uint_0;
				if (int_0 != 0)
				{
					uint num3 = 0u;
					while (num2 < uint_)
					{
						uint num4 = class28_0.uint_1[(int)((UIntPtr)num2)];
						@class.uint_1[(int)(checked((IntPtr)(unchecked((ulong)num2 + (ulong)((long)num)))))] = (num4 << int_0 | num3);
						num3 = num4 >> 32 - int_0;
						num2 += 1u;
					}
					@class.uint_1[(int)(checked((IntPtr)(unchecked((ulong)num2 + (ulong)((long)num)))))] = num3;
				}
				else
				{
					while (num2 < uint_)
					{
						@class.uint_1[(int)(checked((IntPtr)(unchecked((ulong)num2 + (ulong)((long)num)))))] = class28_0.uint_1[(int)((UIntPtr)num2)];
						num2 += 1u;
					}
				}
				@class.method_5();
				return @class;
			}

			public static Class15.Class28 smethod_11(Class15.Class28 class28_0, int int_0)
			{
				if (int_0 == 0)
				{
					return new Class15.Class28(class28_0);
				}
				int num = int_0 >> 5;
				int num2 = int_0 & 31;
				Class15.Class28 @class = new Class15.Class28((Class15.Class28.Enum5)1, class28_0.uint_0 - (uint)num + 1u);
				uint num3 = (uint)(@class.uint_1.Length - 1);
				if (num2 != 0)
				{
					uint num4 = 0u;
					while (num3-- > 0u)
					{
						uint num5 = class28_0.uint_1[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)num)))))];
						@class.uint_1[(int)((UIntPtr)num3)] = (num5 >> int_0 | num4);
						num4 = num5 << 32 - int_0;
					}
				}
				else
				{
					while (num3-- > 0u)
					{
						@class.uint_1[(int)((UIntPtr)num3)] = class28_0.uint_1[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)num)))))];
					}
				}
				@class.method_5();
				return @class;
			}

			public static Class15.Class28 smethod_12(Class15.Class28 class28_0, uint uint_0)
			{
				Class15.Class28 @class = new Class15.Class28((Class15.Class28.Enum5)1, class28_0.uint_0 + 1u);
				uint num = 0u;
				ulong num2 = 0uL;
				do
				{
					num2 += (ulong)class28_0.uint_1[(int)((UIntPtr)num)] * (ulong)uint_0;
					@class.uint_1[(int)((UIntPtr)num)] = (uint)num2;
					num2 >>= 32;
				}
				while ((num += 1u) < class28_0.uint_0);
				@class.uint_1[(int)((UIntPtr)num)] = (uint)num2;
				@class.method_5();
				return @class;
			}

			public unsafe static void smethod_13(uint[] uint_0, uint uint_1, uint uint_2, uint[] uint_3, uint uint_4, uint uint_5, uint[] uint_6, uint uint_7)
			{
				uint* ptr;
				if (uint_0 != null && uint_0.Length != 0)
				{
					fixed (uint* ptr = &uint_0[0])
					{
					}
				}
				else
				{
					ptr = null;
				}
				uint* ptr2;
				if (uint_3 != null && uint_3.Length != 0)
				{
					fixed (uint* ptr2 = &uint_3[0])
					{
					}
				}
				else
				{
					ptr2 = null;
				}
				uint* ptr3;
				if (uint_6 != null && uint_6.Length != 0)
				{
					fixed (uint* ptr3 = &uint_6[0])
					{
					}
				}
				else
				{
					ptr3 = null;
				}
				uint* ptr4 = ptr + uint_1;
				uint* ptr5 = ptr4 + uint_2;
				uint* ptr6 = ptr2 + uint_4;
				uint* ptr7 = ptr6 + uint_5;
				uint* ptr8 = ptr3 + uint_7;
				while (ptr4 < ptr5)
				{
					if (*ptr4 != 0u)
					{
						ulong num = 0uL;
						uint* ptr9 = ptr8;
						uint* ptr10 = ptr6;
						while (ptr10 < ptr7)
						{
							num += (ulong)(*ptr4) * (ulong)(*ptr10) + (ulong)(*ptr9);
							*ptr9 = (uint)num;
							num >>= 32;
							ptr10++;
							ptr9++;
						}
						if (num != 0uL)
						{
							*ptr9 = (uint)num;
						}
					}
					ptr4++;
					ptr8++;
				}
				ptr = null;
				ptr2 = null;
				ptr3 = null;
			}

			public unsafe static void smethod_14(uint[] uint_0, int int_0, int int_1, uint[] uint_1, int int_2, int int_3, uint[] uint_2, int int_4, int int_5)
			{
				uint* ptr;
				if (uint_0 != null && uint_0.Length != 0)
				{
					fixed (uint* ptr = &uint_0[0])
					{
					}
				}
				else
				{
					ptr = null;
				}
				uint* ptr2;
				if (uint_1 != null && uint_1.Length != 0)
				{
					fixed (uint* ptr2 = &uint_1[0])
					{
					}
				}
				else
				{
					ptr2 = null;
				}
				uint* ptr3;
				if (uint_2 != null && uint_2.Length != 0)
				{
					fixed (uint* ptr3 = &uint_2[0])
					{
					}
				}
				else
				{
					ptr3 = null;
				}
				uint* ptr4 = ptr + int_0;
				uint* ptr5 = ptr4 + int_1;
				uint* ptr6 = ptr2 + int_2;
				uint* ptr7 = ptr6 + int_3;
				uint* ptr8 = ptr3 + int_4;
				uint* ptr9 = ptr8 + int_5;
				while (ptr4 < ptr5)
				{
					if (*ptr4 != 0u)
					{
						ulong num = 0uL;
						uint* ptr10 = ptr8;
						uint* ptr11 = ptr6;
						while (ptr11 < ptr7 && ptr10 < ptr9)
						{
							num += (ulong)(*ptr4) * (ulong)(*ptr11) + (ulong)(*ptr10);
							*ptr10 = (uint)num;
							num >>= 32;
							ptr11++;
							ptr10++;
						}
						if (num != 0uL && ptr10 < ptr9)
						{
							*ptr10 = (uint)num;
						}
					}
					ptr4++;
					ptr8++;
				}
				ptr = null;
				ptr2 = null;
				ptr3 = null;
			}

			public unsafe static void smethod_15(Class15.Class28 class28_0, ref uint[] uint_0)
			{
				uint[] array = uint_0;
				uint_0 = class28_0.uint_1;
				uint[] uint_ = class28_0.uint_1;
				uint uint_2 = class28_0.uint_0;
				class28_0.uint_1 = array;
				uint[] array2;
				uint* ptr;
				if ((array2 = uint_) != null && array2.Length != 0)
				{
					fixed (uint* ptr = &array2[0])
					{
					}
				}
				else
				{
					ptr = null;
				}
				uint[] array3;
				uint* ptr2;
				if ((array3 = array) != null && array3.Length != 0)
				{
					fixed (uint* ptr2 = &array3[0])
					{
					}
				}
				else
				{
					ptr2 = null;
				}
				uint* ptr3 = ptr2 + array.Length;
				for (uint* ptr4 = ptr2; ptr4 < ptr3; ptr4++)
				{
					*ptr4 = 0u;
				}
				uint* ptr5 = ptr;
				uint* ptr6 = ptr2;
				uint num = 0u;
				while (num < uint_2)
				{
					if (*ptr5 != 0u)
					{
						ulong num2 = 0uL;
						uint num3 = *ptr5;
						uint* ptr7 = ptr5 + 1;
						uint* ptr8 = ptr6 + 2u * num + 1;
						uint num4 = num + 1u;
						while (num4 < uint_2)
						{
							num2 += (ulong)num3 * (ulong)(*ptr7) + (ulong)(*ptr8);
							*ptr8 = (uint)num2;
							num2 >>= 32;
							num4 += 1u;
							ptr8++;
							ptr7++;
						}
						if (num2 != 0uL)
						{
							*ptr8 = (uint)num2;
						}
					}
					num += 1u;
					ptr5++;
				}
				ptr6 = ptr2;
				uint num5 = 0u;
				while (ptr6 < ptr3)
				{
					uint num6 = *ptr6;
					*ptr6 = (num6 << 1 | num5);
					num5 = num6 >> 31;
					ptr6++;
				}
				if (num5 != 0u)
				{
					*ptr6 = num5;
				}
				ptr5 = ptr;
				ptr6 = ptr2;
				uint* ptr9 = ptr5 + uint_2;
				while (ptr5 < ptr9)
				{
					ulong num7 = (ulong)(*ptr5) * (ulong)(*ptr5) + (ulong)(*ptr6);
					*ptr6 = (uint)num7;
					num7 >>= 32;
					*(++ptr6) += (uint)num7;
					if (*ptr6 < (uint)num7)
					{
						uint* ptr10 = ptr6;
						*(++ptr10) += 1u;
						while (*(ptr10++) == 0u)
						{
							*ptr10 += 1u;
						}
					}
					ptr5++;
					ptr6++;
				}
				class28_0.uint_0 <<= 1;
				while (ptr2[class28_0.uint_0 - 1u] == 0u && class28_0.uint_0 > 1u)
				{
					class28_0.uint_0 -= 1u;
				}
				ptr = null;
				ptr2 = null;
			}

			public static Class15.Class28 smethod_16(Class15.Class28 class28_0, Class15.Class28 class28_1)
			{
				Class15.Class28 @class = class28_0;
				Class15.Class28 class2 = class28_1;
				Class15.Class28 class3 = class2;
				while (@class.uint_0 > 1u)
				{
					class3 = @class;
					@class = class2 % @class;
					class2 = class3;
				}
				if (@class == 0u)
				{
					return class3;
				}
				uint num = @class.uint_1[0];
				uint num2 = class2 % num;
				int num3 = 0;
				while (((num2 | num) & 1u) == 0u)
				{
					num2 >>= 1;
					num >>= 1;
					num3++;
				}
				while (num2 != 0u)
				{
					while ((num2 & 1u) == 0u)
					{
						num2 >>= 1;
					}
					while ((num & 1u) == 0u)
					{
						num >>= 1;
					}
					if (num2 >= num)
					{
						num2 = num2 - num >> 1;
					}
					else
					{
						num = num - num2 >> 1;
					}
				}
				return num << num3;
			}

			public static uint smethod_17(Class15.Class28 class28_0, uint uint_0)
			{
				uint num = uint_0;
				uint num2 = class28_0 % uint_0;
				uint num3 = 0u;
				uint num4 = 1u;
				while (num2 != 0u)
				{
					if (num2 == 1u)
					{
						return num4;
					}
					num3 += num / num2 * num4;
					num %= num2;
					if (num == 0u)
					{
						return 0u;
					}
					if (num == 1u)
					{
						return uint_0 - num3;
					}
					num4 += num2 / num * num3;
					num2 %= num;
				}
				return 0u;
			}

			public static Class15.Class28 smethod_18(Class15.Class28 class28_0, Class15.Class28 class28_1)
			{
				if (class28_1.uint_0 == 1u)
				{
					return Class15.Class28.Class30.smethod_17(class28_0, class28_1.uint_1[0]);
				}
				Class15.Class28[] array = new Class15.Class28[]
				{
					0,
					1
				};
				Class15.Class28[] array2 = new Class15.Class28[2];
				Class15.Class28[] array3 = new Class15.Class28[]
				{
					0,
					0
				};
				int num = 0;
				Class15.Class28 class28_2 = class28_1;
				Class15.Class28 @class = class28_0;
				Class15.Class28.Class29 class2 = new Class15.Class28.Class29(class28_1);
				while (@class != 0u)
				{
					if (num > 1)
					{
						Class15.Class28 class3 = class2.method_2(array[0], array[1] * array2[0]);
						array[0] = array[1];
						array[1] = class3;
					}
					Class15.Class28[] array4 = Class15.Class28.Class30.smethod_9(class28_2, @class);
					array2[0] = array2[1];
					array2[1] = array4[0];
					array3[0] = array3[1];
					array3[1] = array4[1];
					class28_2 = @class;
					@class = array4[1];
					num++;
				}
				if (array3[0] != 1u)
				{
					throw new ArithmeticException("No inverse!");
				}
				return class2.method_2(array[0], array[1] * array2[0]);
			}
		}

		private uint uint_0 = 1u;

		private uint[] uint_1;

		public Class28(Class15.Class28.Enum5 enum5_0, uint uint_2)
		{
			this.uint_1 = new uint[uint_2];
			this.uint_0 = uint_2;
		}

		public Class28(Class15.Class28 class28_0)
		{
			this.uint_1 = (uint[])class28_0.uint_1.Clone();
			this.uint_0 = class28_0.uint_0;
		}

		public Class28(Class15.Class28 class28_0, uint uint_2)
		{
			this.uint_1 = new uint[uint_2];
			for (uint num = 0u; num < class28_0.uint_0; num += 1u)
			{
				this.uint_1[(int)((UIntPtr)num)] = class28_0.uint_1[(int)((UIntPtr)num)];
			}
			this.uint_0 = class28_0.uint_0;
		}

		public Class28(byte[] byte_0)
		{
			this.uint_0 = (uint)byte_0.Length >> 2;
			int num = byte_0.Length & 3;
			if (num != 0)
			{
				this.uint_0 += 1u;
			}
			this.uint_1 = new uint[this.uint_0];
			int i = byte_0.Length - 1;
			int num2 = 0;
			while (i >= 3)
			{
				this.uint_1[num2] = (uint)((int)byte_0[i - 3] << 24 | (int)byte_0[i - 2] << 16 | (int)byte_0[i - 1] << 8 | (int)byte_0[i]);
				i -= 4;
				num2++;
			}
			switch (num)
			{
			case 1:
				this.uint_1[(int)((UIntPtr)(this.uint_0 - 1u))] = (uint)byte_0[0];
				break;
			case 2:
				this.uint_1[(int)((UIntPtr)(this.uint_0 - 1u))] = (uint)((int)byte_0[0] << 8 | (int)byte_0[1]);
				break;
			case 3:
				this.uint_1[(int)((UIntPtr)(this.uint_0 - 1u))] = (uint)((int)byte_0[0] << 16 | (int)byte_0[1] << 8 | (int)byte_0[2]);
				break;
			}
			this.method_5();
		}

		public Class28(uint uint_2)
		{
			this.uint_1 = new uint[]
			{
				uint_2
			};
		}

		public Class28(ulong ulong_0)
		{
			this.uint_1 = new uint[]
			{
				(uint)ulong_0,
				(uint)(ulong_0 >> 32)
			};
			this.uint_0 = 2u;
			this.method_5();
		}

		public static implicit operator Class15.Class28(uint uint_2)
		{
			return new Class15.Class28(uint_2);
		}

		public static implicit operator Class15.Class28(int int_0)
		{
			if (int_0 < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			return new Class15.Class28((uint)int_0);
		}

		public static implicit operator Class15.Class28(ulong ulong_0)
		{
			return new Class15.Class28(ulong_0);
		}

		public static Class15.Class28 operator +(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			if (class28_0 == 0u)
			{
				return new Class15.Class28(class28_1);
			}
			if (class28_1 == 0u)
			{
				return new Class15.Class28(class28_0);
			}
			return Class15.Class28.Class30.smethod_0(class28_0, class28_1);
		}

		public static Class15.Class28 operator -(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			if (class28_1 == 0u)
			{
				return new Class15.Class28(class28_0);
			}
			if (class28_0 == 0u)
			{
				throw new ArithmeticException();
			}
			switch (Class15.Class28.Class30.smethod_4(class28_0, class28_1))
			{
			case (Class15.Class28.Enum5)(-1):
				throw new ArithmeticException();
			case (Class15.Class28.Enum5)0:
				return 0;
			case (Class15.Class28.Enum5)1:
				return Class15.Class28.Class30.smethod_1(class28_0, class28_1);
			default:
				throw new Exception();
			}
		}

		public static int operator %(Class15.Class28 class28_0, int int_0)
		{
			if (int_0 > 0)
			{
				return (int)Class15.Class28.Class30.smethod_6(class28_0, (uint)int_0);
			}
			return (int)(-(int)Class15.Class28.Class30.smethod_6(class28_0, (uint)(-(uint)int_0)));
		}

		public static uint operator %(Class15.Class28 class28_0, uint uint_2)
		{
			return Class15.Class28.Class30.smethod_6(class28_0, uint_2);
		}

		public static Class15.Class28 operator %(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			return Class15.Class28.Class30.smethod_9(class28_0, class28_1)[1];
		}

		public static Class15.Class28 operator /(Class15.Class28 class28_0, int int_0)
		{
			if (int_0 <= 0)
			{
				throw new ArithmeticException();
			}
			return Class15.Class28.Class30.smethod_7(class28_0, (uint)int_0);
		}

		public static Class15.Class28 operator /(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			return Class15.Class28.Class30.smethod_9(class28_0, class28_1)[0];
		}

		public static Class15.Class28 operator *(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			if (class28_0 == 0u || class28_1 == 0u)
			{
				return 0;
			}
			if ((long)class28_0.uint_1.Length < (long)((ulong)class28_0.uint_0))
			{
				throw new IndexOutOfRangeException("bi1 out of range");
			}
			if ((long)class28_1.uint_1.Length < (long)((ulong)class28_1.uint_0))
			{
				throw new IndexOutOfRangeException("bi2 out of range");
			}
			Class15.Class28 @class = new Class15.Class28((Class15.Class28.Enum5)1, class28_0.uint_0 + class28_1.uint_0);
			Class15.Class28.Class30.smethod_13(class28_0.uint_1, 0u, class28_0.uint_0, class28_1.uint_1, 0u, class28_1.uint_0, @class.uint_1, 0u);
			@class.method_5();
			return @class;
		}

		public static Class15.Class28 operator *(Class15.Class28 class28_0, int int_0)
		{
			if (int_0 < 0)
			{
				throw new ArithmeticException();
			}
			if (int_0 == 0)
			{
				return 0;
			}
			if (int_0 == 1)
			{
				return new Class15.Class28(class28_0);
			}
			return Class15.Class28.Class30.smethod_12(class28_0, (uint)int_0);
		}

		public static Class15.Class28 operator <<(Class15.Class28 class28_0, int int_0)
		{
			return Class15.Class28.Class30.smethod_10(class28_0, int_0);
		}

		public static Class15.Class28 operator >>(Class15.Class28 class28_0, int int_0)
		{
			return Class15.Class28.Class30.smethod_11(class28_0, int_0);
		}

		public int method_0()
		{
			this.method_5();
			uint num = this.uint_1[(int)((UIntPtr)(this.uint_0 - 1u))];
			uint num2 = 2147483648u;
			uint num3 = 32u;
			while (num3 > 0u && (num & num2) == 0u)
			{
				num3 -= 1u;
				num2 >>= 1;
			}
			return (int)(num3 + (this.uint_0 - 1u << 5));
		}

		public bool method_1(int int_0)
		{
			if (int_0 < 0)
			{
				throw new IndexOutOfRangeException("bitNum out of range");
			}
			uint num = (uint)int_0 >> 5;
			byte b = (byte)(int_0 & 31);
			uint num2 = 1u << (int)b;
			return (this.uint_1[(int)((UIntPtr)num)] | num2) == this.uint_1[(int)((UIntPtr)num)];
		}

		public byte[] method_2()
		{
			return this.method_3();
		}

		public byte[] method_3()
		{
			if (this == 0u)
			{
				return new byte[1];
			}
			int num = this.method_0();
			int num2 = num >> 3;
			if ((num & 7) != 0)
			{
				num2++;
			}
			byte[] array = new byte[num2];
			int num3 = num2 & 3;
			if (num3 == 0)
			{
				num3 = 4;
			}
			int num4 = 0;
			for (int i = (int)(this.uint_0 - 1u); i >= 0; i--)
			{
				uint num5 = this.uint_1[i];
				for (int j = num3 - 1; j >= 0; j--)
				{
					array[num4 + j] = (byte)(num5 & 255u);
					num5 >>= 8;
				}
				num4 += num3;
				num3 = 4;
			}
			return array;
		}

		public static bool operator ==(Class15.Class28 class28_0, uint uint_2)
		{
			if (class28_0.uint_0 != 1u)
			{
				class28_0.method_5();
			}
			return class28_0.uint_0 == 1u && class28_0.uint_1[0] == uint_2;
		}

		public static bool operator !=(Class15.Class28 class28_0, uint uint_2)
		{
			if (class28_0.uint_0 != 1u)
			{
				class28_0.method_5();
			}
			return class28_0.uint_0 != 1u || class28_0.uint_1[0] != uint_2;
		}

		public static bool operator ==(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			return class28_0 == class28_1 || (!(null == class28_0) && !(null == class28_1) && Class15.Class28.Class30.smethod_4(class28_0, class28_1) == (Class15.Class28.Enum5)0);
		}

		public static bool operator !=(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			return class28_0 != class28_1 && (null == class28_0 || null == class28_1 || Class15.Class28.Class30.smethod_4(class28_0, class28_1) != (Class15.Class28.Enum5)0);
		}

		public static bool operator >(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			return Class15.Class28.Class30.smethod_4(class28_0, class28_1) > (Class15.Class28.Enum5)0;
		}

		public static bool operator <(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			return Class15.Class28.Class30.smethod_4(class28_0, class28_1) < (Class15.Class28.Enum5)0;
		}

		public static bool operator >=(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			return Class15.Class28.Class30.smethod_4(class28_0, class28_1) >= (Class15.Class28.Enum5)0;
		}

		public static bool operator <=(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			return Class15.Class28.Class30.smethod_4(class28_0, class28_1) <= (Class15.Class28.Enum5)0;
		}

		public Class15.Class28.Enum5 method_4(Class15.Class28 class28_0)
		{
			return Class15.Class28.Class30.smethod_4(this, class28_0);
		}

		private void method_5()
		{
			while (this.uint_0 > 0u && this.uint_1[(int)((UIntPtr)(this.uint_0 - 1u))] == 0u)
			{
				this.uint_0 -= 1u;
			}
			if (this.uint_0 == 0u)
			{
				this.uint_0 += 1u;
			}
		}

		public override int GetHashCode()
		{
			uint num = 0u;
			for (uint num2 = 0u; num2 < this.uint_0; num2 += 1u)
			{
				num ^= this.uint_1[(int)((UIntPtr)num2)];
			}
			return (int)num;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj is int)
			{
				return (int)obj >= 0 && this == (uint)obj;
			}
			Class15.Class28 @class = obj as Class15.Class28;
			return !(@class == null) && Class15.Class28.Class30.smethod_4(this, @class) == (Class15.Class28.Enum5)0;
		}

		public Class15.Class28 method_6(Class15.Class28 class28_0)
		{
			return Class15.Class28.Class30.smethod_16(this, class28_0);
		}

		public Class15.Class28 method_7(Class15.Class28 class28_0, Class15.Class28 class28_1)
		{
			Class15.Class28.Class29 @class = new Class15.Class28.Class29(class28_1);
			return @class.method_3(this, class28_0);
		}
	}

	private const double double_0 = 4.6566128730773926E-10;

	private const double double_1 = 2.3283064365386963E-10;

	private const uint uint_0 = 842502087u;

	private const uint uint_1 = 3579807591u;

	private const uint uint_2 = 273326509u;

	private const uint uint_3 = 1073741824u;

	private const uint uint_4 = 2147483648u;

	private const uint uint_5 = 1u;

	private const uint uint_6 = 2u;

	private const uint uint_7 = 1u;

	private const uint uint_8 = 2u;

	private const uint uint_9 = 3u;

	private const uint uint_10 = 4u;

	internal static object object_0;

	internal static object object_1;

	private static SortedList sortedList_0;

	private static SortedList sortedList_1;

	internal static byte[] byte_0;

	private uint uint_11;

	private uint uint_12;

	private uint uint_13;

	private uint uint_14;

	private uint uint_15;

	private uint uint_16 = 1u;

	internal static byte[] byte_1;

	internal static byte[] byte_2;

	internal static string string_0;

	private static string string_1;

	internal static string string_2;

	internal static string string_3;

	private static string string_4;

	private static bool bool_0;

	private static string string_5;

	private static bool bool_1;

	private static string string_6;

	private static bool bool_2;

	private static string string_7;

	private static bool bool_3;

	private static string string_8;

	private static bool bool_4;

	private static string string_9;

	private static bool bool_5;

	static Class15()
	{
		Class15.object_0 = new object();
		Class15.object_1 = new object();
		Class15.sortedList_0 = new SortedList();
		Class15.sortedList_1 = new SortedList();
		Class15.byte_0 = new byte[0];
		byte[] array = new byte[32];
		array[0] = 117;
		array[0] = 100;
		array[0] = 114;
		array[0] = 199;
		array[1] = 142;
		array[1] = 51;
		array[1] = 106;
		array[1] = 83;
		array[1] = 100;
		array[1] = 156;
		array[2] = 117;
		array[2] = 110;
		array[2] = 106;
		array[3] = 120;
		array[3] = 165;
		array[3] = 51;
		array[4] = 88;
		array[4] = 98;
		array[4] = 214;
		array[4] = 129;
		array[4] = 150;
		array[5] = 119;
		array[5] = 124;
		array[5] = 121;
		array[5] = 220;
		array[6] = 101;
		array[6] = 37;
		array[6] = 92;
		array[6] = 113;
		array[7] = 168;
		array[7] = 97;
		array[7] = 178;
		array[8] = 115;
		array[8] = 123;
		array[8] = 130;
		array[8] = 83;
		array[9] = 160;
		array[9] = 119;
		array[9] = 104;
		array[9] = 116;
		array[9] = 150;
		array[9] = 154;
		array[10] = 165;
		array[10] = 71;
		array[10] = 169;
		array[10] = 44;
		array[11] = 118;
		array[11] = 125;
		array[11] = 116;
		array[11] = 130;
		array[11] = 243;
		array[12] = 239;
		array[12] = 168;
		array[12] = 208;
		array[12] = 91;
		array[12] = 108;
		array[12] = 102;
		array[13] = 99;
		array[13] = 98;
		array[13] = 136;
		array[13] = 54;
		array[13] = 135;
		array[13] = 173;
		array[14] = 166;
		array[14] = 130;
		array[14] = 88;
		array[15] = 82;
		array[15] = 184;
		array[15] = 82;
		array[16] = 76;
		array[16] = 111;
		array[16] = 120;
		array[16] = 10;
		array[17] = 120;
		array[17] = 154;
		array[17] = 116;
		array[17] = 162;
		array[17] = 120;
		array[17] = 242;
		array[18] = 108;
		array[18] = 124;
		array[18] = 92;
		array[18] = 133;
		array[18] = 76;
		array[18] = 19;
		array[19] = 140;
		array[19] = 118;
		array[19] = 164;
		array[19] = 103;
		array[19] = 125;
		array[19] = 40;
		array[20] = 65;
		array[20] = 100;
		array[20] = 111;
		array[21] = 107;
		array[21] = 102;
		array[21] = 111;
		array[21] = 227;
		array[22] = 112;
		array[22] = 108;
		array[22] = 102;
		array[22] = 216;
		array[22] = 152;
		array[22] = 230;
		array[23] = 108;
		array[23] = 158;
		array[23] = 139;
		array[23] = 215;
		array[24] = 124;
		array[24] = 82;
		array[24] = 104;
		array[24] = 120;
		array[24] = 96;
		array[24] = 106;
		array[25] = 96;
		array[25] = 116;
		array[25] = 172;
		array[26] = 121;
		array[26] = 166;
		array[26] = 118;
		array[26] = 100;
		array[26] = 66;
		array[27] = 123;
		array[27] = 91;
		array[27] = 162;
		array[27] = 150;
		array[27] = 213;
		array[28] = 127;
		array[28] = 145;
		array[28] = 227;
		array[28] = 0;
		array[29] = 144;
		array[29] = 151;
		array[29] = 116;
		array[30] = 163;
		array[30] = 92;
		array[30] = 151;
		array[31] = 122;
		array[31] = 107;
		array[31] = 158;
		array[31] = 106;
		array[31] = 156;
		array[31] = 48;
		Class15.byte_1 = array;
		byte[] array2 = new byte[16];
		array2[0] = 117;
		array2[0] = 162;
		array2[0] = 188;
		array2[1] = 134;
		array2[1] = 122;
		array2[1] = 96;
		array2[1] = 88;
		array2[1] = 33;
		array2[1] = 68;
		array2[2] = 162;
		array2[2] = 185;
		array2[2] = 32;
		array2[2] = 156;
		array2[2] = 25;
		array2[2] = 167;
		array2[3] = 116;
		array2[3] = 159;
		array2[3] = 199;
		array2[4] = 96;
		array2[4] = 152;
		array2[4] = 103;
		array2[4] = 46;
		array2[4] = 127;
		array2[4] = 54;
		array2[5] = 202;
		array2[5] = 86;
		array2[5] = 86;
		array2[5] = 136;
		array2[5] = 4;
		array2[6] = 161;
		array2[6] = 118;
		array2[6] = 78;
		array2[6] = 73;
		array2[6] = 59;
		array2[7] = 157;
		array2[7] = 168;
		array2[7] = 128;
		array2[7] = 192;
		array2[7] = 162;
		array2[7] = 100;
		array2[8] = 166;
		array2[8] = 126;
		array2[8] = 177;
		array2[8] = 46;
		array2[9] = 116;
		array2[9] = 208;
		array2[9] = 92;
		array2[9] = 116;
		array2[9] = 232;
		array2[10] = 110;
		array2[10] = 156;
		array2[10] = 105;
		array2[10] = 126;
		array2[10] = 88;
		array2[10] = 123;
		array2[11] = 151;
		array2[11] = 130;
		array2[11] = 113;
		array2[11] = 101;
		array2[11] = 128;
		array2[11] = 248;
		array2[12] = 94;
		array2[12] = 158;
		array2[12] = 149;
		array2[12] = 137;
		array2[12] = 151;
		array2[12] = 195;
		array2[13] = 138;
		array2[13] = 74;
		array2[13] = 251;
		array2[14] = 149;
		array2[14] = 123;
		array2[14] = 82;
		array2[15] = 172;
		array2[15] = 148;
		array2[15] = 95;
		array2[15] = 244;
		Class15.byte_2 = array2;
		Class15.string_0 = "";
		Class15.string_1 = null;
		Class15.string_2 = "";
		Class15.string_3 = "";
		Class15.string_4 = "";
		Class15.bool_0 = false;
		Class15.string_5 = "";
		Class15.bool_1 = false;
		Class15.string_6 = "";
		Class15.bool_2 = false;
		Class15.string_7 = "";
		Class15.bool_3 = false;
		Class15.string_8 = "";
		Class15.bool_4 = false;
		Class15.string_9 = "";
		Class15.bool_5 = false;
	}

	public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
	{
		License result;
		lock (Class15.object_0)
		{
			result = this.method_10(context, type, instance, allowExceptions, false, false, false, "", "", null, false, false, false);
		}
		return result;
	}

	internal void method_0(int int_0)
	{
		this.uint_11 = (uint)int_0;
		this.uint_12 = 842502087u;
		this.uint_13 = 3579807591u;
		this.uint_14 = 273326509u;
	}

	internal int method_1()
	{
		uint num = this.uint_11 ^ this.uint_11 << 11;
		this.uint_11 = this.uint_12;
		this.uint_12 = this.uint_13;
		this.uint_13 = this.uint_14;
		this.uint_14 = (this.uint_14 ^ this.uint_14 >> 19 ^ (num ^ num >> 8));
		uint num2 = this.uint_14 & 2147483647u;
		if (num2 == 2147483647u)
		{
			return this.method_1();
		}
		return (int)num2;
	}

	internal int method_2(int int_0)
	{
		if (int_0 < 0)
		{
			throw new Exception("upperBound=" + int_0.ToString() + "; upperBound must be >=0");
		}
		uint num = this.uint_11 ^ this.uint_11 << 11;
		this.uint_11 = this.uint_12;
		this.uint_12 = this.uint_13;
		this.uint_13 = this.uint_14;
		return (int)(4.6566128730773926E-10 * (double)(2147483647u & (this.uint_14 = (this.uint_14 ^ this.uint_14 >> 19 ^ (num ^ num >> 8)))) * (double)int_0);
	}

	internal int method_3(int int_0, int int_1)
	{
		int num = this.method_4(int_0, int_1);
		if (num >= int_0 && num <= int_1)
		{
			return num;
		}
		return int_1;
	}

	private int method_4(int int_0, int int_1)
	{
		if (int_0 > int_1)
		{
			throw new Exception("upperBound must be >=lowerBound");
		}
		uint num = this.uint_11 ^ this.uint_11 << 11;
		this.uint_11 = this.uint_12;
		this.uint_12 = this.uint_13;
		this.uint_13 = this.uint_14;
		int num2 = int_1 - int_0;
		if (num2 < 0)
		{
			return int_0 + (int)(2.3283064365386963E-10 * (this.uint_14 = (this.uint_14 ^ this.uint_14 >> 19 ^ (num ^ num >> 8))) * (double)((long)int_1 - (long)int_0));
		}
		return int_0 + (int)(4.6566128730773926E-10 * (double)(2147483647u & (this.uint_14 = (this.uint_14 ^ this.uint_14 >> 19 ^ (num ^ num >> 8)))) * (double)num2);
	}

	internal double method_5()
	{
		uint num = this.uint_11 ^ this.uint_11 << 11;
		this.uint_11 = this.uint_12;
		this.uint_12 = this.uint_13;
		this.uint_13 = this.uint_14;
		return 4.6566128730773926E-10 * (double)(2147483647u & (this.uint_14 = (this.uint_14 ^ this.uint_14 >> 19 ^ (num ^ num >> 8))));
	}

	internal void method_6(byte[] byte_3)
	{
		uint num = this.uint_11;
		uint num2 = this.uint_12;
		uint num3 = this.uint_13;
		uint num4 = this.uint_14;
		int i = 0;
		int num5 = byte_3.Length - 3;
		while (i < num5)
		{
			uint num6 = num ^ num << 11;
			num = num2;
			num2 = num3;
			num3 = num4;
			num4 = (num4 ^ num4 >> 19 ^ (num6 ^ num6 >> 8));
			byte_3[i++] = (byte)num4;
			byte_3[i++] = (byte)(num4 >> 8);
			byte_3[i++] = (byte)(num4 >> 16);
			byte_3[i++] = (byte)(num4 >> 24);
		}
		if (i < byte_3.Length)
		{
			uint num6 = num ^ num << 11;
			num = num2;
			num2 = num3;
			num3 = num4;
			num4 = (num4 ^ num4 >> 19 ^ (num6 ^ num6 >> 8));
			byte_3[i++] = (byte)num4;
			if (i < byte_3.Length)
			{
				byte_3[i++] = (byte)(num4 >> 8);
				if (i < byte_3.Length)
				{
					byte_3[i++] = (byte)(num4 >> 16);
					if (i < byte_3.Length)
					{
						byte_3[i] = (byte)(num4 >> 24);
					}
				}
			}
		}
		this.uint_11 = num;
		this.uint_12 = num2;
		this.uint_13 = num3;
		this.uint_14 = num4;
	}

	internal uint method_7()
	{
		uint num = this.uint_11 ^ this.uint_11 << 11;
		this.uint_11 = this.uint_12;
		this.uint_12 = this.uint_13;
		this.uint_13 = this.uint_14;
		return this.uint_14 = (this.uint_14 ^ this.uint_14 >> 19 ^ (num ^ num >> 8));
	}

	internal int method_8()
	{
		uint num = this.uint_11 ^ this.uint_11 << 11;
		this.uint_11 = this.uint_12;
		this.uint_12 = this.uint_13;
		this.uint_13 = this.uint_14;
		return (int)(2147483647u & (this.uint_14 = (this.uint_14 ^ this.uint_14 >> 19 ^ (num ^ num >> 8))));
	}

	internal bool method_9()
	{
		if (this.uint_16 == 1u)
		{
			uint num = this.uint_11 ^ this.uint_11 << 11;
			this.uint_11 = this.uint_12;
			this.uint_12 = this.uint_13;
			this.uint_13 = this.uint_14;
			this.uint_15 = (this.uint_14 = (this.uint_14 ^ this.uint_14 >> 19 ^ (num ^ num >> 8)));
			this.uint_16 = 2147483648u;
			return (this.uint_15 & this.uint_16) == 0u;
		}
		return (this.uint_15 & (this.uint_16 >>= 1)) == 0u;
	}

	private void ilHifFeDUTsZtKIFfN18()
	{
	}

	internal License method_10(LicenseContext licenseContext_0, Type type_0, object object_2, bool bool_6, bool bool_7, bool bool_8, bool bool_9, string string_10, string string_11, byte[] byte_3, bool bool_10, bool bool_11, bool bool_12)
	{
		if (!bool_7 && !bool_8 && !bool_9 && !bool_11 && !bool_12)
		{
			if (licenseContext_0 == null)
			{
				return null;
			}
			if (Class15.sortedList_1[type_0.Assembly.FullName] != null)
			{
				if ((bool)Class15.sortedList_0[type_0.Assembly.FullName])
				{
					return (Class15.Class26)Class15.sortedList_1[type_0.Assembly.FullName];
				}
				return null;
			}
			else if (Class15.sortedList_1[typeof(Class15).Assembly.FullName] != null)
			{
				AssemblyName[] referencedAssemblies = typeof(Class15).Assembly.GetReferencedAssemblies();
				int i = 0;
				while (i < referencedAssemblies.Length)
				{
					if (!(type_0.Assembly.GetName().FullName == referencedAssemblies[i].FullName))
					{
						i++;
					}
					else
					{
						if ((bool)Class15.sortedList_0[typeof(Class15).Assembly.FullName])
						{
							return (Class15.Class26)Class15.sortedList_1[typeof(Class15).Assembly.FullName];
						}
						return null;
					}
				}
			}
			else
			{
				AssemblyName[] referencedAssemblies2 = typeof(Class15).Assembly.GetReferencedAssemblies();
				for (int j = 0; j < referencedAssemblies2.Length; j++)
				{
					if (typeof(Class15).Assembly.GetName().FullName == referencedAssemblies2[j].FullName)
					{
						type_0 = typeof(Class15);
						break;
					}
				}
			}
		}
		Class15.Class18 @class = new Class15.Class18();
		new Class15.Class26(this, "");
		BinaryReader binaryReader = new BinaryReader(typeof(Class15).Assembly.GetManifestResourceStream("f41b6698-d795-4f0b-a290-8c1f75203a8d"));
		binaryReader.BaseStream.Position = 0L;
		byte[] array = new byte[0];
		byte[] array2 = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
		byte[] array3 = new byte[32];
		array3[0] = 117;
		array3[0] = 100;
		array3[0] = 114;
		array3[0] = 199;
		array3[1] = 142;
		array3[1] = 51;
		array3[1] = 106;
		array3[1] = 83;
		array3[1] = 100;
		array3[1] = 156;
		array3[2] = 117;
		array3[2] = 110;
		array3[2] = 106;
		array3[3] = 120;
		array3[3] = 165;
		array3[3] = 51;
		array3[4] = 88;
		array3[4] = 98;
		array3[4] = 214;
		array3[4] = 129;
		array3[4] = 150;
		array3[5] = 119;
		array3[5] = 124;
		array3[5] = 121;
		array3[5] = 220;
		array3[6] = 101;
		array3[6] = 37;
		array3[6] = 92;
		array3[6] = 113;
		array3[7] = 168;
		array3[7] = 97;
		array3[7] = 178;
		array3[8] = 115;
		array3[8] = 123;
		array3[8] = 130;
		array3[8] = 83;
		array3[9] = 160;
		array3[9] = 119;
		array3[9] = 104;
		array3[9] = 116;
		array3[9] = 150;
		array3[9] = 154;
		array3[10] = 165;
		array3[10] = 71;
		array3[10] = 169;
		array3[10] = 44;
		array3[11] = 118;
		array3[11] = 125;
		array3[11] = 116;
		array3[11] = 130;
		array3[11] = 243;
		array3[12] = 239;
		array3[12] = 168;
		array3[12] = 208;
		array3[12] = 91;
		array3[12] = 108;
		array3[12] = 102;
		array3[13] = 99;
		array3[13] = 98;
		array3[13] = 136;
		array3[13] = 54;
		array3[13] = 135;
		array3[13] = 173;
		array3[14] = 166;
		array3[14] = 130;
		array3[14] = 88;
		array3[15] = 82;
		array3[15] = 184;
		array3[15] = 82;
		array3[16] = 76;
		array3[16] = 111;
		array3[16] = 120;
		array3[16] = 10;
		array3[17] = 120;
		array3[17] = 154;
		array3[17] = 116;
		array3[17] = 162;
		array3[17] = 120;
		array3[17] = 242;
		array3[18] = 108;
		array3[18] = 124;
		array3[18] = 92;
		array3[18] = 133;
		array3[18] = 76;
		array3[18] = 19;
		array3[19] = 140;
		array3[19] = 118;
		array3[19] = 164;
		array3[19] = 103;
		array3[19] = 125;
		array3[19] = 40;
		array3[20] = 65;
		array3[20] = 100;
		array3[20] = 111;
		array3[21] = 107;
		array3[21] = 102;
		array3[21] = 111;
		array3[21] = 227;
		array3[22] = 112;
		array3[22] = 108;
		array3[22] = 102;
		array3[22] = 216;
		array3[22] = 152;
		array3[22] = 230;
		array3[23] = 108;
		array3[23] = 158;
		array3[23] = 139;
		array3[23] = 215;
		array3[24] = 124;
		array3[24] = 82;
		array3[24] = 104;
		array3[24] = 120;
		array3[24] = 96;
		array3[24] = 106;
		array3[25] = 96;
		array3[25] = 116;
		array3[25] = 172;
		array3[26] = 121;
		array3[26] = 166;
		array3[26] = 118;
		array3[26] = 100;
		array3[26] = 66;
		array3[27] = 123;
		array3[27] = 91;
		array3[27] = 162;
		array3[27] = 150;
		array3[27] = 213;
		array3[28] = 127;
		array3[28] = 145;
		array3[28] = 227;
		array3[28] = 0;
		array3[29] = 144;
		array3[29] = 151;
		array3[29] = 116;
		array3[30] = 163;
		array3[30] = 92;
		array3[30] = 151;
		array3[31] = 122;
		array3[31] = 107;
		array3[31] = 158;
		array3[31] = 106;
		array3[31] = 156;
		array3[31] = 48;
		Class15.byte_1 = array3;
		byte[] array4 = new byte[16];
		array4[0] = 117;
		array4[0] = 162;
		array4[0] = 188;
		array4[1] = 134;
		array4[1] = 122;
		array4[1] = 96;
		array4[1] = 88;
		array4[1] = 33;
		array4[1] = 68;
		array4[2] = 162;
		array4[2] = 185;
		array4[2] = 32;
		array4[2] = 156;
		array4[2] = 25;
		array4[2] = 167;
		array4[3] = 116;
		array4[3] = 159;
		array4[3] = 199;
		array4[4] = 96;
		array4[4] = 152;
		array4[4] = 103;
		array4[4] = 46;
		array4[4] = 127;
		array4[4] = 54;
		array4[5] = 202;
		array4[5] = 86;
		array4[5] = 86;
		array4[5] = 136;
		array4[5] = 4;
		array4[6] = 161;
		array4[6] = 118;
		array4[6] = 78;
		array4[6] = 73;
		array4[6] = 59;
		array4[7] = 157;
		array4[7] = 168;
		array4[7] = 128;
		array4[7] = 192;
		array4[7] = 162;
		array4[7] = 100;
		array4[8] = 166;
		array4[8] = 126;
		array4[8] = 177;
		array4[8] = 46;
		array4[9] = 116;
		array4[9] = 208;
		array4[9] = 92;
		array4[9] = 116;
		array4[9] = 232;
		array4[10] = 110;
		array4[10] = 156;
		array4[10] = 105;
		array4[10] = 126;
		array4[10] = 88;
		array4[10] = 123;
		array4[11] = 151;
		array4[11] = 130;
		array4[11] = 113;
		array4[11] = 101;
		array4[11] = 128;
		array4[11] = 248;
		array4[12] = 94;
		array4[12] = 158;
		array4[12] = 149;
		array4[12] = 137;
		array4[12] = 151;
		array4[12] = 195;
		array4[13] = 138;
		array4[13] = 74;
		array4[13] = 251;
		array4[14] = 149;
		array4[14] = 123;
		array4[14] = 82;
		array4[15] = 172;
		array4[15] = 148;
		array4[15] = 95;
		array4[15] = 244;
		Class15.byte_2 = array4;
		if (bool_8)
		{
			try
			{
				Class15.smethod_5();
				Class15.Class17 class2 = null;
				try
				{
					string str = Class15.Class16.string_0;
					string str2 = Class15.string_3 + "\\";
					RegistryKey registryKey = Registry.CurrentUser;
					if (Class15.smethod_0())
					{
						registryKey = Registry.LocalMachine;
					}
					RegistryKey registryKey2 = registryKey.OpenSubKey(str + str2, false);
					if (registryKey2 != null)
					{
						Class15.Class17 class3 = new Class15.Class17();
						class3.method_0((string)registryKey2.GetValue("1"), Class15.byte_1, Class15.byte_2);
						if (class2 == null)
						{
							class2 = class3;
						}
						if (class3.ulong_0 > class2.ulong_0)
						{
							class2 = class3;
						}
					}
				}
				catch
				{
				}
				try
				{
					if (Class14.smethod_5(type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(type_0.Assembly).ToString()))
					{
						Class15.Class17 class4 = new Class15.Class17();
						class4.method_0(Class15.smethod_8(Path.GetDirectoryName(Class14.smethod_5(type_0.Assembly).ToString()), Class15.string_2), Class15.byte_1, Class15.byte_2);
						if (class2 == null)
						{
							class2 = class4;
						}
						if (class4.ulong_0 > class2.ulong_0)
						{
							class2 = class4;
						}
					}
				}
				catch
				{
				}
				try
				{
					if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2))
					{
						Class15.Class17 class5 = new Class15.Class17();
						class5.method_0(Encoding.Unicode.GetString(Class15.smethod_11(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2)), Class15.byte_1, Class15.byte_2);
						if (class2 == null)
						{
							class2 = class5;
						}
						if (class5.ulong_0 > class2.ulong_0)
						{
							class2 = class5;
						}
					}
				}
				catch
				{
				}
				if (class2 == null)
				{
					class2 = new Class15.Class17();
				}
				this.method_0(Environment.TickCount);
				class2.int_3 = this.method_3(10000000, 2147483646);
				try
				{
					string str3 = Class15.Class16.string_0;
					string str4 = Class15.string_3 + "\\";
					RegistryKey registryKey3 = Registry.CurrentUser;
					if (Class15.smethod_0())
					{
						registryKey3 = Registry.LocalMachine;
					}
					RegistryKey registryKey4;
					if (registryKey3.OpenSubKey(str3 + str4, false) == null)
					{
						registryKey3 = Registry.CurrentUser;
						if (Class15.smethod_0())
						{
							registryKey3 = Registry.LocalMachine;
						}
						registryKey4 = registryKey3.CreateSubKey(str3 + str4);
					}
					registryKey3 = Registry.CurrentUser;
					if (Class15.smethod_0())
					{
						registryKey3 = Registry.LocalMachine;
					}
					registryKey4 = registryKey3.OpenSubKey(str3 + str4, true);
					if (registryKey4 != null)
					{
						registryKey4.SetValue("1", class2.method_5(Class15.byte_1, Class15.byte_2));
						registryKey4.Close();
					}
				}
				catch
				{
				}
				try
				{
					if (Class14.smethod_5(type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(type_0.Assembly).ToString()))
					{
						Class15.smethod_7(Path.GetDirectoryName(Class14.smethod_5(type_0.Assembly).ToString()), Class15.string_2, class2.method_5(Class15.byte_1, Class15.byte_2));
					}
				}
				catch
				{
				}
				try
				{
					FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2, FileMode.Create, FileAccess.ReadWrite);
					byte[] bytes = Encoding.Unicode.GetBytes(class2.method_5(Class15.byte_1, Class15.byte_2));
					fileStream.Write(bytes, 0, bytes.Length);
					fileStream.Close();
				}
				catch
				{
				}
				ICryptoTransform transform = new RijndaelManaged
				{
					Mode = CipherMode.CBC
				}.CreateEncryptor(Class15.byte_1, Class15.byte_2);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				byte[] array5 = new byte[0];
				if (string_10.Length > 0)
				{
					array5 = Encoding.ASCII.GetBytes(string_10 + class2.int_3.ToString());
				}
				else
				{
					array5 = Encoding.ASCII.GetBytes(Class15.smethod_3(true, false, true, true, false, false) + class2.int_3.ToString());
				}
				cryptoStream.Write(array5, 0, array5.Length);
				cryptoStream.FlushFinalBlock();
				array = memoryStream.ToArray();
				Class34.string_0 = Convert.ToBase64String(array);
				memoryStream.Close();
				cryptoStream.Close();
				class2 = null;
			}
			catch
			{
			}
			return null;
		}
		License result;
		if (bool_9)
		{
			try
			{
				Class15.smethod_5();
				Class15.Class17 class6 = null;
				try
				{
					string str5 = Class15.Class16.string_0;
					string str6 = Class15.string_3 + "\\";
					RegistryKey registryKey5 = Registry.CurrentUser;
					if (Class15.smethod_0())
					{
						registryKey5 = Registry.LocalMachine;
					}
					RegistryKey registryKey6 = registryKey5.OpenSubKey(str5 + str6, false);
					if (registryKey6 != null)
					{
						Class15.Class17 class7 = new Class15.Class17();
						class7.method_0((string)registryKey6.GetValue("1"), Class15.byte_1, Class15.byte_2);
						if (class6 == null)
						{
							class6 = class7;
						}
						if (class7.ulong_0 > class6.ulong_0)
						{
							class6 = class7;
						}
					}
				}
				catch
				{
				}
				try
				{
					if (Class14.smethod_5(type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(type_0.Assembly).ToString()))
					{
						Class15.Class17 class8 = new Class15.Class17();
						class8.method_0(Class15.smethod_8(Path.GetDirectoryName(Class14.smethod_5(type_0.Assembly).ToString()), Class15.string_2), Class15.byte_1, Class15.byte_2);
						if (class6 == null)
						{
							class6 = class8;
						}
						if (class8.ulong_0 > class6.ulong_0)
						{
							class6 = class8;
						}
					}
				}
				catch
				{
				}
				try
				{
					if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2))
					{
						Class15.Class17 class9 = new Class15.Class17();
						class9.method_0(Encoding.Unicode.GetString(Class15.smethod_11(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2)), Class15.byte_1, Class15.byte_2);
						if (class6 == null)
						{
							class6 = class9;
						}
						if (class9.ulong_0 > class6.ulong_0)
						{
							class6 = class9;
						}
					}
				}
				catch
				{
				}
				if (class6.int_3 == 0)
				{
					result = new Class15.Class26(this, "");
					return result;
				}
				byte[] array6 = Convert.FromBase64String(string_10);
				ICryptoTransform transform2 = new RijndaelManaged
				{
					Mode = CipherMode.CBC
				}.CreateDecryptor(Class15.byte_1, Class15.byte_2);
				MemoryStream memoryStream2 = new MemoryStream();
				CryptoStream cryptoStream2 = new CryptoStream(memoryStream2, transform2, CryptoStreamMode.Write);
				byte[] array7 = array6;
				cryptoStream2.Write(array7, 0, array7.Length);
				cryptoStream2.FlushFinalBlock();
				array = memoryStream2.ToArray();
				memoryStream2.Close();
				cryptoStream2.Close();
				string @string = Encoding.Unicode.GetString(array, 0, array.Length);
				if (@string != null && @string.Length > 0 && @string.IndexOf(class6.int_3.ToString()) >= 0)
				{
					class6.int_3 = 0;
					try
					{
						string str7 = Class15.Class16.string_0;
						string str8 = Class15.string_3 + "\\";
						RegistryKey registryKey7 = Registry.CurrentUser;
						if (Class15.smethod_0())
						{
							registryKey7 = Registry.LocalMachine;
						}
						RegistryKey registryKey8;
						if (registryKey7.OpenSubKey(str7 + str8, false) == null)
						{
							registryKey7 = Registry.CurrentUser;
							if (Class15.smethod_0())
							{
								registryKey7 = Registry.LocalMachine;
							}
							registryKey8 = registryKey7.CreateSubKey(str7 + str8);
						}
						registryKey7 = Registry.CurrentUser;
						if (Class15.smethod_0())
						{
							registryKey7 = Registry.LocalMachine;
						}
						registryKey8 = registryKey7.OpenSubKey(str7 + str8, true);
						if (registryKey8 != null)
						{
							registryKey8.SetValue("1", class6.method_5(Class15.byte_1, Class15.byte_2));
							registryKey8.Close();
						}
					}
					catch
					{
					}
					try
					{
						if (Class14.smethod_5(type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(type_0.Assembly).ToString()))
						{
							Class15.smethod_7(Path.GetDirectoryName(Class14.smethod_5(type_0.Assembly).ToString()), Class15.string_2, class6.method_5(Class15.byte_1, Class15.byte_2));
						}
					}
					catch
					{
					}
					try
					{
						FileStream fileStream2 = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2, FileMode.Create, FileAccess.ReadWrite);
						byte[] bytes2 = Encoding.Unicode.GetBytes(class6.method_5(Class15.byte_1, Class15.byte_2));
						fileStream2.Write(bytes2, 0, bytes2.Length);
						fileStream2.Close();
					}
					catch
					{
					}
					result = new Class15.Class26(this, "");
					return result;
				}
				result = null;
				return result;
			}
			catch
			{
				result = null;
				return result;
			}
		}
		ICryptoTransform transform3 = new RijndaelManaged
		{
			Mode = CipherMode.CBC
		}.CreateDecryptor(Class15.byte_1, Class15.byte_2);
		MemoryStream memoryStream3 = new MemoryStream();
		CryptoStream cryptoStream3 = new CryptoStream(memoryStream3, transform3, CryptoStreamMode.Write);
		cryptoStream3.Write(array2, 0, array2.Length);
		cryptoStream3.FlushFinalBlock();
		array = memoryStream3.ToArray();
		memoryStream3.Close();
		cryptoStream3.Close();
		binaryReader.Close();
		if (!@class.method_0(array))
		{
			try
			{
				Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
			}
			catch
			{
			}
			return null;
		}
		if (!@class.method_1(array))
		{
			try
			{
				Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
			}
			catch
			{
			}
			return null;
		}
		if (!@class.bool_13)
		{
			try
			{
				Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
			}
			catch
			{
			}
			return null;
		}
		if (bool_11)
		{
			ICryptoTransform transform4 = new RijndaelManaged
			{
				Mode = CipherMode.CBC
			}.CreateDecryptor(Class15.byte_1, Class15.byte_2);
			MemoryStream memoryStream4 = new MemoryStream();
			CryptoStream cryptoStream4 = new CryptoStream(memoryStream4, transform4, CryptoStreamMode.Write);
			cryptoStream4.Write(byte_3, 0, byte_3.Length);
			cryptoStream4.FlushFinalBlock();
			byte[] array8 = memoryStream4.ToArray();
			memoryStream4.Close();
			cryptoStream4.Close();
			if (!@class.method_0(array8))
			{
				return null;
			}
			return new Class15.Class26(this, "");
		}
		else
		{
			if (bool_12)
			{
				ICryptoTransform transform5 = new RijndaelManaged
				{
					Mode = CipherMode.CBC
				}.CreateDecryptor(Class15.byte_1, Class15.byte_2);
				MemoryStream memoryStream5 = new MemoryStream();
				CryptoStream cryptoStream5 = new CryptoStream(memoryStream5, transform5, CryptoStreamMode.Write);
				cryptoStream5.Write(byte_3, 0, byte_3.Length);
				cryptoStream5.FlushFinalBlock();
				byte[] buffer = memoryStream5.ToArray();
				memoryStream5.Close();
				cryptoStream5.Close();
				MemoryStream memoryStream6 = new MemoryStream(buffer);
				BinaryReader binaryReader2 = new BinaryReader(memoryStream6);
				memoryStream6.Position = 0L;
				byte[] array9 = binaryReader2.ReadBytes(binaryReader2.ReadInt32());
				byte[] array10 = binaryReader2.ReadBytes((int)(memoryStream6.Length - 4L - (long)array9.Length));
				binaryReader2.Close();
				Class35.byte_0 = array10;
				return new Class15.Class26(this, "");
			}
			@class.string_2 = "";
			@class.int_0 = 5;
			@class.int_1 = 0;
			@class.bool_2 = false;
			@class.bool_4 = false;
			@class.bool_12 = false;
			@class.bool_13 = false;
			@class.bool_3 = false;
			Class15.Class18 class10 = null;
			if (!@class.bool_16 && !@class.bool_15 && !@class.bool_17 && !@class.bool_18 && !@class.bool_19 && !@class.bool_20 && !@class.bool_21)
			{
				Class15.sortedList_0[type_0.Assembly.FullName] = true;
				Class15.sortedList_1[type_0.Assembly.FullName] = new Class15.Class26(this, "");
				return new Class15.Class26(this, "");
			}
			Class33.smethod_0().method_7((Enum7)0);
			Class15.smethod_5();
			bool flag = false;
			bool flag2 = false;
			Class15.Class17 class11 = null;
			try
			{
				string str9 = Class15.Class16.string_0;
				string str10 = Class15.string_3 + "\\";
				RegistryKey registryKey9 = Registry.CurrentUser;
				if (Class15.smethod_0())
				{
					registryKey9 = Registry.LocalMachine;
				}
				RegistryKey registryKey10 = registryKey9.OpenSubKey(str9 + str10, false);
				if (registryKey10 != null)
				{
					Class15.Class17 class12 = new Class15.Class17();
					class12.method_0((string)registryKey10.GetValue("1"), Class15.byte_1, Class15.byte_2);
					if (class11 == null)
					{
						class11 = class12;
					}
					if (class12.ulong_0 > class11.ulong_0)
					{
						class11 = class12;
					}
				}
			}
			catch
			{
			}
			try
			{
				if (Class14.smethod_5(type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(type_0.Assembly).ToString()))
				{
					Class15.Class17 class13 = new Class15.Class17();
					class13.method_0(Class15.smethod_8(Path.GetDirectoryName(Class14.smethod_5(type_0.Assembly).ToString()), Class15.string_2), Class15.byte_1, Class15.byte_2);
					if (class11 == null)
					{
						class11 = class13;
					}
					if (class13.ulong_0 > class11.ulong_0)
					{
						class11 = class13;
					}
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2))
				{
					Class15.Class17 class14 = new Class15.Class17();
					class14.method_0(Encoding.Unicode.GetString(Class15.smethod_11(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2)), Class15.byte_1, Class15.byte_2);
					if (class11 == null)
					{
						class11 = class14;
					}
					if (class14.ulong_0 > class11.ulong_0)
					{
						class11 = class14;
					}
				}
			}
			catch
			{
			}
			if (class11 == null)
			{
				class11 = new Class15.Class17();
			}
			bool flag3 = false;
			if (class11 != null && class11.int_3 > 0)
			{
				Class33.smethod_0().method_1((Enum6)8);
				Class33.smethod_0().method_3((Enum6)8);
				Class33.smethod_0().method_5((Enum6)8);
				flag3 = true;
				Class15.sortedList_0[type_0.Assembly.FullName] = true;
				Class15.sortedList_1[type_0.Assembly.FullName] = new Class15.Class26(this, "");
			}
			class11 = null;
			if (!flag3)
			{
				if (bool_7)
				{
					byte[] array11 = new byte[0];
					if (string_11.Length > 0)
					{
						try
						{
							array11 = Class15.smethod_11(string_11);
							goto IL_192C;
						}
						catch
						{
							goto IL_192C;
						}
					}
					array11 = byte_3;
					IL_192C:
					if (array11.Length > 0)
					{
						Class15.Class18 class15 = new Class15.Class18();
						array = new byte[0];
						try
						{
							array2 = array11;
							ICryptoTransform transform6 = new RijndaelManaged
							{
								Mode = CipherMode.CBC
							}.CreateDecryptor(Class15.byte_1, Class15.byte_2);
							MemoryStream memoryStream7 = new MemoryStream();
							CryptoStream cryptoStream6 = new CryptoStream(memoryStream7, transform6, CryptoStreamMode.Write);
							cryptoStream6.Write(array2, 0, array2.Length);
							cryptoStream6.FlushFinalBlock();
							array = memoryStream7.ToArray();
							memoryStream7.Close();
							cryptoStream6.Close();
						}
						catch
						{
							array = new byte[0];
						}
						if (array.Length > 0)
						{
							if (class15.method_0(array))
							{
								bool flag4 = true;
								class15.method_1(array);
								if (class15.bool_4)
								{
									string text = Class15.smethod_3(class15.bool_6, class15.bool_7, class15.bool_11, class15.bool_5, class15.bool_8, class15.bool_9);
									if (text.Length == 29)
									{
										int num = 0;
										if (class15.bool_8 && class15.string_3.Substring(0, 4) != text.Substring(0, 4))
										{
											num++;
										}
										if (class15.bool_6 && class15.string_3.Substring(5, 4) != text.Substring(5, 4))
										{
											num++;
										}
										if (class15.bool_7 && class15.string_3.Substring(10, 4) != text.Substring(10, 4))
										{
											num++;
										}
										if (class15.bool_11 && class15.string_3.Substring(15, 4) != text.Substring(15, 4))
										{
											num++;
										}
										if (class15.bool_5 && class15.string_3.Substring(20, 4) != text.Substring(20, 4))
										{
											num++;
										}
										if (class15.bool_9 && class15.string_3.Substring(25, 4) != text.Substring(25, 4))
										{
											num++;
										}
										if (class15.int_1 - num < 0)
										{
											Class33.smethod_0().method_5((Enum6)5);
											flag4 = false;
											flag = true;
										}
									}
									else
									{
										flag = true;
										flag4 = false;
										Class33.smethod_0().method_5((Enum6)5);
									}
								}
								if (flag4 && licenseContext_0 != null)
								{
									if (licenseContext_0.UsageMode == LicenseUsageMode.Runtime && !class15.bool_0)
									{
										Class33.smethod_0().method_5((Enum6)0);
										flag4 = false;
									}
									if (licenseContext_0.UsageMode == LicenseUsageMode.Designtime && !class15.bool_1)
									{
										Class33.smethod_0().method_5((Enum6)0);
										flag4 = false;
									}
								}
								if (class15.bool_13)
								{
									flag4 = false;
								}
								if (flag4)
								{
									class10 = class15;
								}
								if (flag4)
								{
									Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
									bool flag5 = false;
									int k = 0;
									while (k < assemblies.Length)
									{
										bool flag6 = true;
										IDictionaryEnumerator enumerator = class10.hashtable_0.GetEnumerator();
										while (enumerator.MoveNext())
										{
											string a = enumerator.Key.ToString();
											string b = enumerator.Value.ToString();
											if (a == Class15.Class16.string_4)
											{
												if (this.method_11(assemblies[k], typeof(AssemblyVersionAttribute)) != b)
												{
													flag6 = false;
												}
											}
											else if (a == Class15.Class16.string_5)
											{
												if (this.method_11(assemblies[k], typeof(AssemblyCopyrightAttribute)) != b)
												{
													flag6 = false;
												}
											}
											else if (a == Class15.Class16.string_6)
											{
												if (this.method_11(assemblies[k], typeof(AssemblyTrademarkAttribute)) != b)
												{
													flag6 = false;
												}
											}
											else if (a == Class15.Class16.string_7)
											{
												if (this.method_11(assemblies[k], typeof(AssemblyCompanyAttribute)) != b)
												{
													flag6 = false;
												}
											}
											else if (a == Class15.Class16.string_8)
											{
												if (this.method_11(assemblies[k], typeof(AssemblyProductAttribute)) != b)
												{
													flag6 = false;
												}
											}
											else if (a == Class15.Class16.string_9)
											{
												if (this.method_11(assemblies[k], typeof(AssemblyDescriptionAttribute)) != b)
												{
													flag6 = false;
												}
											}
											else if (a == Class15.Class16.string_10)
											{
												if (this.method_11(assemblies[k], typeof(AssemblyTitleAttribute)) != b)
												{
													flag6 = false;
												}
											}
											else if (a == Class15.Class16.string_3 && this.method_11(assemblies[k], typeof(AssemblyName)) != b)
											{
												flag6 = false;
											}
										}
										if (!flag6)
										{
											k++;
										}
										else
										{
											flag5 = true;
											IL_1DE1:
											if (!flag5)
											{
												class10 = null;
											}
											if (class10 == null)
											{
												Class33.smethod_0().method_5((Enum6)6);
												flag2 = true;
												goto IL_1DF7;
											}
											goto IL_1DF7;
										}
									}
									goto IL_1DE1;
								}
								IL_1DF7:
								if (flag4 && class10 != null && class15.bool_2)
								{
									try
									{
										Class15.Class19 class16 = new Class15.Class19(class15.string_2);
										Random random = new Random();
										byte[] array12 = new byte[16];
										random.NextBytes(array12);
										byte[] array13 = new byte[byte_3.Length + 16];
										Array.Copy(array12, 0, array13, 0, array12.Length);
										Array.Copy(byte_3, 0, array13, array12.Length, byte_3.Length);
										array12 = array13;
										byte[] array14 = class16.Activate(array12);
										byte[] buffer2 = new byte[0];
										ICryptoTransform transform7 = new RijndaelManaged
										{
											Mode = CipherMode.CBC
										}.CreateDecryptor(Class15.byte_1, Class15.byte_2);
										MemoryStream memoryStream8 = new MemoryStream();
										CryptoStream cryptoStream7 = new CryptoStream(memoryStream8, transform7, CryptoStreamMode.Write);
										cryptoStream7.Write(array14, 0, array14.Length);
										cryptoStream7.FlushFinalBlock();
										buffer2 = memoryStream8.ToArray();
										memoryStream8.Close();
										cryptoStream7.Close();
										if (@class.method_0(buffer2))
										{
											MemoryStream memoryStream9 = new MemoryStream(buffer2);
											BinaryReader binaryReader3 = new BinaryReader(memoryStream9);
											memoryStream9.Position = 0L;
											byte[] array15 = binaryReader3.ReadBytes(binaryReader3.ReadInt32());
											byte[] array16 = binaryReader3.ReadBytes((int)(memoryStream9.Length - 4L - (long)array15.Length));
											binaryReader3.Close();
											if (Convert.ToBase64String(array12, 0, 16) != Convert.ToBase64String(array16, 0, 16))
											{
												Class33.smethod_0().method_5((Enum6)7);
												class10 = null;
											}
											else if (array16[16] == 0)
											{
												Class33.smethod_0().method_5((Enum6)7);
												class10 = null;
											}
										}
										else
										{
											Class33.smethod_0().method_5((Enum6)7);
											class10 = null;
										}
									}
									catch
									{
										Class33.smethod_0().method_5((Enum6)7);
										class10 = null;
									}
								}
								if (class10 != null)
								{
									Class15.byte_0 = byte_3;
									if (class10.bool_10)
									{
										Class15.string_0 = class10.string_1;
									}
									else
									{
										Class15.string_0 = "";
									}
									Class33.smethod_0().method_5((Enum6)0);
									Class33.smethod_0().method_7((Enum7)2);
								}
							}
							else
							{
								Class33.smethod_0().method_5((Enum6)6);
								flag2 = true;
							}
						}
					}
				}
				else
				{
					if (class10 == null && @class.bool_23)
					{
						Class33.smethod_0().method_3((Enum6)4);
						ArrayList arrayList = new ArrayList();
						try
						{
							if (Assembly.GetCallingAssembly() != null)
							{
								arrayList.Add(Assembly.GetCallingAssembly());
							}
						}
						catch
						{
						}
						try
						{
							if (Assembly.GetEntryAssembly() != null)
							{
								arrayList.Add(Assembly.GetEntryAssembly());
							}
						}
						catch
						{
						}
						try
						{
							if (Assembly.GetExecutingAssembly() != null)
							{
								arrayList.Add(Assembly.GetExecutingAssembly());
							}
						}
						catch
						{
						}
						arrayList.Add(type_0.Assembly);
						for (int l = 0; l < arrayList.Count; l++)
						{
							try
							{
								string text2 = @class.string_13.Replace(Class15.Class16.string_32, Class15.Class16.string_33);
								string[] manifestResourceNames = ((Assembly)arrayList[l]).GetManifestResourceNames();
								for (int m = 0; m < manifestResourceNames.Length; m++)
								{
									try
									{
										if (manifestResourceNames[m].ToUpper().IndexOf(text2.ToUpper()) >= 0)
										{
											Class15.Class18 class17 = new Class15.Class18();
											array = new byte[0];
											byte[] array17 = new byte[0];
											try
											{
												Stream manifestResourceStream = ((Assembly)arrayList[l]).GetManifestResourceStream(manifestResourceNames[m]);
												manifestResourceStream.Position = 0L;
												array2 = new byte[manifestResourceStream.Length];
												manifestResourceStream.Read(array2, 0, array2.Length);
												manifestResourceStream.Close();
												array17 = array2;
												ICryptoTransform transform8 = new RijndaelManaged
												{
													Mode = CipherMode.CBC
												}.CreateDecryptor(Class15.byte_1, Class15.byte_2);
												MemoryStream memoryStream10 = new MemoryStream();
												CryptoStream cryptoStream8 = new CryptoStream(memoryStream10, transform8, CryptoStreamMode.Write);
												cryptoStream8.Write(array2, 0, array2.Length);
												cryptoStream8.FlushFinalBlock();
												array = memoryStream10.ToArray();
												memoryStream10.Close();
												cryptoStream8.Close();
											}
											catch
											{
												array = new byte[0];
											}
											if (array.Length > 0)
											{
												if (class17.method_0(array))
												{
													bool flag7 = true;
													class17.method_1(array);
													if (class17.bool_4)
													{
														string text3 = Class15.smethod_3(class17.bool_6, class17.bool_7, class17.bool_11, class17.bool_5, class17.bool_8, class17.bool_9);
														if (text3.Length == 29)
														{
															int num2 = 0;
															if (class17.bool_8 && class17.string_3.Substring(0, 4) != text3.Substring(0, 4))
															{
																num2++;
															}
															if (class17.bool_6 && class17.string_3.Substring(5, 4) != text3.Substring(5, 4))
															{
																num2++;
															}
															if (class17.bool_7 && class17.string_3.Substring(10, 4) != text3.Substring(10, 4))
															{
																num2++;
															}
															if (class17.bool_11 && class17.string_3.Substring(15, 4) != text3.Substring(15, 4))
															{
																num2++;
															}
															if (class17.bool_5 && class17.string_3.Substring(20, 4) != text3.Substring(20, 4))
															{
																num2++;
															}
															if (class17.bool_9 && class17.string_3.Substring(25, 4) != text3.Substring(25, 4))
															{
																num2++;
															}
															if (class17.int_1 - num2 < 0)
															{
																Class33.smethod_0().method_3((Enum6)5);
																flag = true;
																flag7 = false;
															}
														}
														else
														{
															Class33.smethod_0().method_3((Enum6)5);
															flag = true;
															flag7 = false;
														}
													}
													if (flag7 && licenseContext_0 != null)
													{
														if (licenseContext_0.UsageMode == LicenseUsageMode.Runtime && !class17.bool_0)
														{
															Class33.smethod_0().method_3((Enum6)0);
															flag7 = false;
														}
														if (licenseContext_0.UsageMode == LicenseUsageMode.Designtime && !class17.bool_1)
														{
															Class33.smethod_0().method_3((Enum6)0);
															flag7 = false;
														}
													}
													if (class17.bool_13)
													{
														flag7 = false;
													}
													if (flag7)
													{
														class10 = class17;
													}
													if (flag7)
													{
														IDictionaryEnumerator enumerator2 = class10.hashtable_0.GetEnumerator();
														while (enumerator2.MoveNext())
														{
															string a2 = enumerator2.Key.ToString();
															string b2 = enumerator2.Value.ToString();
															if (a2 == Class15.Class16.string_4)
															{
																if (this.method_11((Assembly)arrayList[l], typeof(AssemblyVersionAttribute)) != b2)
																{
																	class10 = null;
																}
															}
															else if (a2 == Class15.Class16.string_5)
															{
																if (this.method_11((Assembly)arrayList[l], typeof(AssemblyCopyrightAttribute)) != b2)
																{
																	class10 = null;
																}
															}
															else if (a2 == Class15.Class16.string_6)
															{
																if (this.method_11((Assembly)arrayList[l], typeof(AssemblyTrademarkAttribute)) != b2)
																{
																	class10 = null;
																}
															}
															else if (a2 == Class15.Class16.string_7)
															{
																if (this.method_11((Assembly)arrayList[l], typeof(AssemblyCompanyAttribute)) != b2)
																{
																	class10 = null;
																}
															}
															else if (a2 == Class15.Class16.string_8)
															{
																if (this.method_11((Assembly)arrayList[l], typeof(AssemblyProductAttribute)) != b2)
																{
																	class10 = null;
																}
															}
															else if (a2 == Class15.Class16.string_9)
															{
																if (this.method_11((Assembly)arrayList[l], typeof(AssemblyDescriptionAttribute)) != b2)
																{
																	class10 = null;
																}
															}
															else if (a2 == Class15.Class16.string_10)
															{
																if (this.method_11((Assembly)arrayList[l], typeof(AssemblyTitleAttribute)) != b2)
																{
																	class10 = null;
																}
															}
															else if (a2 == Class15.Class16.string_3 && this.method_11((Assembly)arrayList[l], typeof(AssemblyName)) != b2)
															{
																class10 = null;
															}
														}
														if (class10 == null)
														{
															Class33.smethod_0().method_3((Enum6)6);
															flag2 = true;
														}
													}
													if (flag7 && class10 != null && class17.bool_2)
													{
														try
														{
															Class15.Class19 class18 = new Class15.Class19(class17.string_2);
															Random random2 = new Random();
															byte[] array18 = new byte[16];
															random2.NextBytes(array18);
															byte[] array19 = new byte[array17.Length + 16];
															Array.Copy(array18, 0, array19, 0, array18.Length);
															Array.Copy(array17, 0, array19, array18.Length, array17.Length);
															array18 = array19;
															byte[] array20 = class18.Activate(array18);
															byte[] buffer3 = new byte[0];
															ICryptoTransform transform9 = new RijndaelManaged
															{
																Mode = CipherMode.CBC
															}.CreateDecryptor(Class15.byte_1, Class15.byte_2);
															MemoryStream memoryStream11 = new MemoryStream();
															CryptoStream cryptoStream9 = new CryptoStream(memoryStream11, transform9, CryptoStreamMode.Write);
															cryptoStream9.Write(array20, 0, array20.Length);
															cryptoStream9.FlushFinalBlock();
															buffer3 = memoryStream11.ToArray();
															memoryStream11.Close();
															cryptoStream9.Close();
															if (@class.method_0(buffer3))
															{
																MemoryStream memoryStream12 = new MemoryStream(buffer3);
																BinaryReader binaryReader4 = new BinaryReader(memoryStream12);
																memoryStream12.Position = 0L;
																byte[] array21 = binaryReader4.ReadBytes(binaryReader4.ReadInt32());
																byte[] array22 = binaryReader4.ReadBytes((int)(memoryStream12.Length - 4L - (long)array21.Length));
																binaryReader4.Close();
																if (Convert.ToBase64String(array18, 0, 16) != Convert.ToBase64String(array22, 0, 16))
																{
																	Class33.smethod_0().method_3((Enum6)7);
																	class10 = null;
																}
																else if (array22[16] == 0)
																{
																	Class33.smethod_0().method_3((Enum6)7);
																	class10 = null;
																}
															}
															else
															{
																Class33.smethod_0().method_3((Enum6)7);
																class10 = null;
															}
														}
														catch
														{
															Class33.smethod_0().method_3((Enum6)7);
															class10 = null;
														}
													}
													if (class10 != null)
													{
														if (class10.bool_10)
														{
															Class15.string_0 = class10.string_1;
														}
														else
														{
															Class15.string_0 = "";
														}
														Class15.byte_0 = array17;
														Class33.smethod_0().method_3((Enum6)0);
														Class33.smethod_0().method_7((Enum7)1);
														break;
													}
												}
												else
												{
													Class33.smethod_0().method_3((Enum6)6);
													flag2 = true;
												}
											}
										}
									}
									catch
									{
									}
								}
							}
							catch
							{
							}
						}
					}
					if (class10 == null && @class.bool_24)
					{
						Class33.smethod_0().method_5((Enum6)4);
						ArrayList arrayList2 = new ArrayList();
						if (File.Exists(Class15.smethod_1()))
						{
							arrayList2.Add(Path.GetDirectoryName(Class15.smethod_1()) + "\\");
						}
						else if (Class14.smethod_5(type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(type_0.Assembly).ToString()))
						{
							arrayList2.Add(Path.GetDirectoryName(Class14.smethod_5(type_0.Assembly).ToString()) + "\\");
						}
						try
						{
							if (File.Exists(Class15.smethod_1()) && Class14.smethod_5(type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(type_0.Assembly).ToString()) && Path.GetDirectoryName(Class15.smethod_1()).ToString() != Path.GetDirectoryName(Class14.smethod_5(type_0.Assembly).ToString()).ToString())
							{
								arrayList2.Add(Path.GetDirectoryName(Class14.smethod_5(type_0.Assembly).ToString()) + "\\");
							}
						}
						catch
						{
						}
						try
						{
							if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory) && arrayList2.IndexOf(AppDomain.CurrentDomain.BaseDirectory) < 0)
							{
								arrayList2.Add(AppDomain.CurrentDomain.BaseDirectory);
							}
						}
						catch
						{
						}
						try
						{
							if (Directory.Exists(AppDomain.CurrentDomain.SetupInformation.PrivateBinPath))
							{
								arrayList2.Add(AppDomain.CurrentDomain.SetupInformation.PrivateBinPath);
							}
						}
						catch
						{
						}
						try
						{
							if (AppDomain.CurrentDomain.GetData("DataDirectory") != null)
							{
								string text4 = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
								if (Directory.Exists(text4))
								{
									arrayList2.Add(text4 + "\\");
								}
							}
						}
						catch
						{
						}
						for (int n = 0; n < arrayList2.Count; n++)
						{
							try
							{
								string[] files = Directory.GetFiles((string)arrayList2[n], @class.string_13);
								for (int num3 = 0; num3 < files.Length; num3++)
								{
									try
									{
										Class15.Class18 class19 = new Class15.Class18();
										array = new byte[0];
										byte[] array23 = new byte[0];
										try
										{
											FileStream fileStream3 = new FileStream(files[num3], FileMode.Open, FileAccess.Read);
											fileStream3.Position = 0L;
											array2 = new byte[fileStream3.Length];
											fileStream3.Read(array2, 0, array2.Length);
											fileStream3.Close();
											array23 = array2;
											ICryptoTransform transform10 = new RijndaelManaged
											{
												Mode = CipherMode.CBC
											}.CreateDecryptor(Class15.byte_1, Class15.byte_2);
											MemoryStream memoryStream13 = new MemoryStream();
											CryptoStream cryptoStream10 = new CryptoStream(memoryStream13, transform10, CryptoStreamMode.Write);
											cryptoStream10.Write(array2, 0, array2.Length);
											cryptoStream10.FlushFinalBlock();
											array = memoryStream13.ToArray();
											memoryStream13.Close();
											cryptoStream10.Close();
										}
										catch
										{
											array = new byte[0];
										}
										if (array.Length > 0)
										{
											if (class19.method_0(array))
											{
												bool flag8 = true;
												class19.method_1(array);
												if (class19.bool_4)
												{
													string text5 = Class15.smethod_3(class19.bool_6, class19.bool_7, class19.bool_11, class19.bool_5, class19.bool_8, class19.bool_9);
													if (text5.Length == 29)
													{
														int num4 = 0;
														if (class19.bool_8 && class19.string_3.Substring(0, 4) != text5.Substring(0, 4))
														{
															num4++;
														}
														if (class19.bool_6 && class19.string_3.Substring(5, 4) != text5.Substring(5, 4))
														{
															num4++;
														}
														if (class19.bool_7 && class19.string_3.Substring(10, 4) != text5.Substring(10, 4))
														{
															num4++;
														}
														if (class19.bool_11 && class19.string_3.Substring(15, 4) != text5.Substring(15, 4))
														{
															num4++;
														}
														if (class19.bool_5 && class19.string_3.Substring(20, 4) != text5.Substring(20, 4))
														{
															num4++;
														}
														if (class19.bool_9 && class19.string_3.Substring(25, 4) != text5.Substring(25, 4))
														{
															num4++;
														}
														if (class19.int_1 - num4 < 0)
														{
															Class33.smethod_0().method_5((Enum6)5);
															flag8 = false;
															flag = true;
														}
													}
													else
													{
														flag = true;
														flag8 = false;
														Class33.smethod_0().method_5((Enum6)5);
													}
												}
												if (flag8 && licenseContext_0 != null)
												{
													if (licenseContext_0.UsageMode == LicenseUsageMode.Runtime && !class19.bool_0)
													{
														Class33.smethod_0().method_5((Enum6)0);
														flag8 = false;
													}
													if (licenseContext_0.UsageMode == LicenseUsageMode.Designtime && !class19.bool_1)
													{
														Class33.smethod_0().method_5((Enum6)0);
														flag8 = false;
													}
												}
												if (class19.bool_13)
												{
													flag8 = false;
												}
												if (flag8)
												{
													class10 = class19;
												}
												if (flag8)
												{
													Assembly[] assemblies2 = AppDomain.CurrentDomain.GetAssemblies();
													bool flag9 = false;
													int num5 = 0;
													while (num5 < assemblies2.Length)
													{
														bool flag10 = true;
														IDictionaryEnumerator enumerator3 = class10.hashtable_0.GetEnumerator();
														while (enumerator3.MoveNext())
														{
															string a3 = enumerator3.Key.ToString();
															string b3 = enumerator3.Value.ToString();
															if (a3 == Class15.Class16.string_4)
															{
																if (this.method_11(assemblies2[num5], typeof(AssemblyVersionAttribute)) != b3)
																{
																	flag10 = false;
																}
															}
															else if (a3 == Class15.Class16.string_5)
															{
																if (this.method_11(assemblies2[num5], typeof(AssemblyCopyrightAttribute)) != b3)
																{
																	flag10 = false;
																}
															}
															else if (a3 == Class15.Class16.string_6)
															{
																if (this.method_11(assemblies2[num5], typeof(AssemblyTrademarkAttribute)) != b3)
																{
																	flag10 = false;
																}
															}
															else if (a3 == Class15.Class16.string_7)
															{
																if (this.method_11(assemblies2[num5], typeof(AssemblyCompanyAttribute)) != b3)
																{
																	flag10 = false;
																}
															}
															else if (a3 == Class15.Class16.string_8)
															{
																if (this.method_11(assemblies2[num5], typeof(AssemblyProductAttribute)) != b3)
																{
																	flag10 = false;
																}
															}
															else if (a3 == Class15.Class16.string_9)
															{
																if (this.method_11(assemblies2[num5], typeof(AssemblyDescriptionAttribute)) != b3)
																{
																	flag10 = false;
																}
															}
															else if (a3 == Class15.Class16.string_10)
															{
																if (this.method_11(assemblies2[num5], typeof(AssemblyTitleAttribute)) != b3)
																{
																	flag10 = false;
																}
															}
															else if (a3 == Class15.Class16.string_3 && this.method_11(assemblies2[n], typeof(AssemblyName)) != b3)
															{
																flag10 = false;
															}
														}
														if (!flag10)
														{
															num5++;
														}
														else
														{
															flag9 = true;
															IL_2F63:
															if (!flag9)
															{
																class10 = null;
															}
															if (class10 == null)
															{
																Class33.smethod_0().method_5((Enum6)6);
																flag2 = true;
																goto IL_2F7A;
															}
															goto IL_2F7A;
														}
													}
													goto IL_2F63;
												}
												IL_2F7A:
												if (flag8 && class10 != null && class19.bool_2)
												{
													try
													{
														Class15.Class19 class20 = new Class15.Class19(class19.string_2);
														Random random3 = new Random();
														byte[] array24 = new byte[16];
														random3.NextBytes(array24);
														byte[] array25 = new byte[array23.Length + 16];
														Array.Copy(array24, 0, array25, 0, array24.Length);
														Array.Copy(array23, 0, array25, array24.Length, array23.Length);
														array24 = array25;
														byte[] array26 = class20.Activate(array24);
														byte[] buffer4 = new byte[0];
														ICryptoTransform transform11 = new RijndaelManaged
														{
															Mode = CipherMode.CBC
														}.CreateDecryptor(Class15.byte_1, Class15.byte_2);
														MemoryStream memoryStream14 = new MemoryStream();
														CryptoStream cryptoStream11 = new CryptoStream(memoryStream14, transform11, CryptoStreamMode.Write);
														cryptoStream11.Write(array26, 0, array26.Length);
														cryptoStream11.FlushFinalBlock();
														buffer4 = memoryStream14.ToArray();
														memoryStream14.Close();
														cryptoStream11.Close();
														if (@class.method_0(buffer4))
														{
															MemoryStream memoryStream15 = new MemoryStream(buffer4);
															BinaryReader binaryReader5 = new BinaryReader(memoryStream15);
															memoryStream15.Position = 0L;
															byte[] array27 = binaryReader5.ReadBytes(binaryReader5.ReadInt32());
															byte[] array28 = binaryReader5.ReadBytes((int)(memoryStream15.Length - 4L - (long)array27.Length));
															binaryReader5.Close();
															if (Convert.ToBase64String(array24, 0, 16) != Convert.ToBase64String(array28, 0, 16))
															{
																Class33.smethod_0().method_5((Enum6)7);
																class10 = null;
															}
															else if (array28[16] == 0)
															{
																Class33.smethod_0().method_5((Enum6)7);
																class10 = null;
															}
														}
														else
														{
															Class33.smethod_0().method_5((Enum6)7);
															class10 = null;
														}
													}
													catch (Exception)
													{
														Class33.smethod_0().method_5((Enum6)7);
														class10 = null;
													}
												}
												if (class10 != null)
												{
													if (class10.bool_10)
													{
														Class15.string_0 = class10.string_1;
													}
													else
													{
														Class15.string_0 = "";
													}
													Class15.byte_0 = array23;
													Class33.smethod_0().method_5((Enum6)0);
													Class33.smethod_0().method_7((Enum7)2);
													break;
												}
											}
											else
											{
												Class33.smethod_0().method_5((Enum6)6);
												flag2 = true;
											}
										}
									}
									catch
									{
									}
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			bool flag11 = false;
			bool flag12 = true;
			if (class10 != null)
			{
				flag11 = true;
				@class.bool_2 = class10.bool_2;
				@class.string_2 = class10.string_2;
				@class.bool_3 = class10.bool_3;
				@class.int_0 = class10.int_0;
				@class.int_1 = class10.int_1;
				@class.bool_12 = class10.bool_12;
				@class.hashtable_0 = class10.hashtable_0;
				@class.bool_4 = class10.bool_4;
				@class.string_3 = class10.string_3;
				@class.bool_6 = class10.bool_6;
				@class.bool_7 = class10.bool_7;
				@class.bool_5 = class10.bool_5;
				@class.bool_11 = class10.bool_11;
				@class.bool_8 = class10.bool_8;
				@class.bool_9 = class10.bool_9;
				if (!class10.bool_16 && !class10.bool_15 && !class10.bool_17 && !class10.bool_18 && !class10.bool_19 && !class10.bool_20 && !class10.bool_21)
				{
					flag12 = false;
				}
				if (!class10.bool_12)
				{
					flag12 = false;
				}
				else
				{
					@class.bool_21 = class10.bool_21;
					@class.bool_16 = class10.bool_16;
					@class.dateTime_0 = class10.dateTime_0;
					@class.bool_15 = class10.bool_15;
					@class.int_2 = class10.int_2;
					@class.bool_17 = class10.bool_17;
					@class.int_3 = class10.int_3;
					@class.bool_18 = class10.bool_18;
					@class.int_4 = class10.int_4;
					@class.bool_19 = class10.bool_19;
					@class.int_5 = class10.int_5;
					@class.bool_20 = class10.bool_20;
					@class.int_6 = class10.int_6;
				}
			}
			else
			{
				@class.bool_4 = false;
				@class.string_3 = Class15.Class16.string_11;
				@class.bool_6 = false;
				@class.bool_7 = false;
				@class.bool_5 = false;
				@class.bool_11 = false;
				@class.bool_8 = false;
				@class.bool_9 = false;
				@class.bool_2 = false;
				@class.string_2 = "";
				@class.bool_3 = false;
				@class.int_0 = 0;
				@class.int_1 = 0;
				if (!@class.bool_26)
				{
					Class15.Class21.timer_0 = new System.Threading.Timer(new TimerCallback(new Class15.Class21().method_0), null, 90000, 30000);
					if (@class.bool_31)
					{
						string message = @class.string_7;
						try
						{
							Class15.EnableWindow(Process.GetCurrentProcess().MainWindowHandle, false);
						}
						catch
						{
						}
						Class15.ShowMessage(message);
					}
					try
					{
						Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
					}
					catch
					{
					}
					return null;
				}
			}
			if (flag12 && @class.bool_21)
			{
				@class.bool_16 = false;
				@class.dateTime_0 = DateTime.Now;
				@class.bool_15 = false;
				@class.int_2 = 28;
				@class.bool_17 = false;
				@class.int_3 = 20;
				@class.bool_18 = false;
				@class.int_4 = 10;
				@class.bool_19 = false;
				@class.int_5 = 60;
				@class.bool_20 = false;
				@class.int_6 = 1;
			}
			if (flag11)
			{
				if (flag12)
				{
					Class33.smethod_0().method_1((Enum6)2);
				}
				else
				{
					Class33.smethod_0().method_1((Enum6)1);
				}
			}
			else if (@class.bool_21)
			{
				if (flag3)
				{
					Class33.smethod_0().method_1((Enum6)8);
				}
				else if (flag)
				{
					Class33.smethod_0().method_1((Enum6)5);
				}
				else if (flag2)
				{
					Class33.smethod_0().method_1((Enum6)6);
				}
				else
				{
					Class33.smethod_0().method_1((Enum6)4);
				}
			}
			else if (flag12)
			{
				Class33.smethod_0().method_1((Enum6)2);
			}
			else
			{
				Class33.smethod_0().method_1((Enum6)0);
			}
			if (Class33.smethod_0().method_6() == (Enum7)2)
			{
				Class33.smethod_0().method_5(Class33.smethod_0().method_0());
			}
			if (Class33.smethod_0().method_6() == (Enum7)1)
			{
				Class33.smethod_0().method_3(Class33.smethod_0().method_0());
			}
			Class33.smethod_0().method_43(@class.bool_21);
			Class33.smethod_0().method_27(@class.bool_17);
			Class33.smethod_0().method_23(@class.int_3);
			Class33.smethod_0().method_25(0);
			Class33.smethod_0().method_15(@class.bool_16);
			Class33.smethod_0().method_13(@class.dateTime_0);
			Class33.smethod_0().method_17(@class.bool_15);
			Class33.smethod_0().method_19(@class.int_2);
			Class33.smethod_0().method_21(0);
			Class33.smethod_0().method_33(@class.bool_19);
			Class33.smethod_0().method_35(@class.int_5);
			Class33.smethod_0().method_37(0);
			Class33.smethod_0().method_41(@class.bool_20);
			Class33.smethod_0().method_39(@class.int_6);
			Class33.smethod_0().method_29(@class.bool_18);
			Class33.smethod_0().method_31(@class.int_4);
			Class33.smethod_0().method_50().Clear();
			if (class10 != null)
			{
				IDictionaryEnumerator enumerator4 = @class.hashtable_0.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					Class33.smethod_0().method_50().Add(enumerator4.Key.ToString(), enumerator4.Value.ToString());
				}
			}
			Class33.smethod_0().method_9(@class.bool_2);
			Class33.smethod_0().method_11(@class.string_2);
			Class33.smethod_0().method_49(@class.string_3);
			Class33.smethod_0().method_47(@class.bool_4);
			Class33.smethod_0().method_57(@class.bool_6);
			Class33.smethod_0().method_59(@class.bool_7);
			Class33.smethod_0().method_55(@class.bool_5);
			Class33.smethod_0().method_53(@class.bool_11);
			Class33.smethod_0().method_61(@class.bool_9);
			Class33.smethod_0().method_63(@class.bool_8);
			Class33.smethod_0().method_67(@class.int_1);
			Class33.smethod_0().method_65(@class.bool_12);
			Class15.smethod_5();
			class11 = new Class15.Class17();
			if (flag12)
			{
				if (@class.bool_34)
				{
					string string_12 = @class.string_11;
					Class15.ShowMessage(string_12);
				}
				if (@class.bool_21)
				{
					Class15.sortedList_0[type_0.Assembly.FullName] = true;
					Class15.sortedList_1[type_0.Assembly.FullName] = new Class15.Class26(this, "");
					return new Class15.Class26(this, "");
				}
				if (@class.bool_20)
				{
					try
					{
						string processName = Process.GetCurrentProcess().ProcessName;
						Process[] processesByName = Process.GetProcessesByName(processName);
						if (processesByName.Length > @class.int_6)
						{
							if (@class.bool_32)
							{
								string text6 = @class.string_8;
								text6 = text6.Replace(Class15.Class16.string_21, @class.int_6.ToString());
								if (@class.bool_25)
								{
									try
									{
										Class15.EnableWindow(Process.GetCurrentProcess().MainWindowHandle, false);
									}
									catch
									{
									}
								}
								Class15.ShowMessage(text6);
							}
							if (@class.bool_25)
							{
								try
								{
									Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
								}
								catch
								{
								}
								result = null;
								return result;
							}
						}
					}
					catch
					{
					}
				}
				Class15.smethod_5();
				class11 = null;
				try
				{
					string str11 = Class15.Class16.string_0;
					string str12 = Class15.string_3 + "\\";
					RegistryKey registryKey11 = Registry.CurrentUser;
					if (Class15.smethod_0())
					{
						registryKey11 = Registry.LocalMachine;
					}
					RegistryKey registryKey12 = registryKey11.OpenSubKey(str11 + str12, false);
					if (registryKey12 != null)
					{
						Class15.Class17 class21 = new Class15.Class17();
						class21.method_0((string)registryKey12.GetValue("1"), Class15.byte_1, Class15.byte_2);
						if (class11 == null)
						{
							class11 = class21;
						}
						if (class21.ulong_0 > class11.ulong_0)
						{
							class11 = class21;
						}
					}
				}
				catch
				{
				}
				try
				{
					if (Class14.smethod_5(type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(type_0.Assembly).ToString()))
					{
						Class15.Class17 class22 = new Class15.Class17();
						class22.method_0(Class15.smethod_8(Path.GetDirectoryName(Class14.smethod_5(type_0.Assembly).ToString()), Class15.string_2), Class15.byte_1, Class15.byte_2);
						if (class11 == null)
						{
							class11 = class22;
						}
						if (class22.ulong_0 > class11.ulong_0)
						{
							class11 = class22;
						}
					}
				}
				catch
				{
				}
				try
				{
					if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2))
					{
						Class15.Class17 class23 = new Class15.Class17();
						class23.method_0(Encoding.Unicode.GetString(Class15.smethod_11(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2)), Class15.byte_1, Class15.byte_2);
						if (class11 == null)
						{
							class11 = class23;
						}
						if (class23.ulong_0 > class11.ulong_0)
						{
							class11 = class23;
						}
					}
				}
				catch
				{
				}
				if (class11 == null)
				{
					class11 = new Class15.Class17();
				}
				try
				{
					class11.ulong_0 += 1uL;
				}
				catch
				{
					class11.ulong_0 = 0uL;
				}
				DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
				if (@class.bool_15)
				{
					class11.int_2 += Math.Abs(dateTime.Subtract(class11.dateTime_1).Days);
				}
				class11.dateTime_1 = dateTime;
				if (@class.bool_16)
				{
					if (DateTime.Compare(dateTime, class11.dateTime_0) >= 0)
					{
						class11.dateTime_0 = dateTime;
					}
				}
				else
				{
					class11.dateTime_0 = dateTime;
				}
				if (@class.bool_17)
				{
					class11.int_0++;
				}
				int num6 = 0;
				int num7 = 0;
				bool flag13 = false;
				bool flag14 = false;
				bool flag15 = false;
				bool flag16 = false;
				if (@class.bool_18 && @class.bool_22)
				{
					num6++;
				}
				if (@class.bool_19)
				{
					num6++;
					if (class11.int_1 >= @class.int_5)
					{
						num7++;
						flag16 = true;
					}
				}
				if (@class.bool_17)
				{
					num6++;
					if (class11.int_0 > @class.int_3)
					{
						num7++;
						flag15 = true;
					}
				}
				if (@class.bool_15)
				{
					num6++;
					if (class11.int_2 > @class.int_2)
					{
						num7++;
						flag14 = true;
					}
				}
				if (@class.bool_16)
				{
					num6++;
					if (class11.dateTime_0 >= @class.dateTime_0)
					{
						num7++;
						flag13 = true;
					}
				}
				if (@class.bool_17 && flag15 && class11.int_0 > @class.int_3 + 1 && ((@class.bool_22 && num6 == num7) || (!@class.bool_22 && num7 > 0)))
				{
					Class33.smethod_0().method_1((Enum6)3);
					if (Class33.smethod_0().method_6() == (Enum7)2)
					{
						Class33.smethod_0().method_5(Class33.smethod_0().method_0());
					}
					if (Class33.smethod_0().method_6() == (Enum7)1)
					{
						Class33.smethod_0().method_3(Class33.smethod_0().method_0());
					}
					if (@class.bool_25)
					{
						class11.int_0--;
					}
				}
				Class33.smethod_0().method_25(class11.int_0);
				Class33.smethod_0().method_21(class11.int_2);
				Class33.smethod_0().method_37(class11.int_1);
				try
				{
					string str13 = Class15.Class16.string_0;
					string str14 = Class15.string_3 + "\\";
					RegistryKey registryKey13 = Registry.CurrentUser;
					if (Class15.smethod_0())
					{
						registryKey13 = Registry.LocalMachine;
					}
					RegistryKey registryKey14;
					if (registryKey13.OpenSubKey(str13 + str14, false) == null)
					{
						registryKey13 = Registry.CurrentUser;
						if (Class15.smethod_0())
						{
							registryKey13 = Registry.LocalMachine;
						}
						registryKey14 = registryKey13.CreateSubKey(str13 + str14);
					}
					registryKey13 = Registry.CurrentUser;
					if (Class15.smethod_0())
					{
						registryKey13 = Registry.LocalMachine;
					}
					registryKey14 = registryKey13.OpenSubKey(str13 + str14, true);
					if (registryKey14 != null)
					{
						registryKey14.SetValue("1", class11.method_5(Class15.byte_1, Class15.byte_2));
						registryKey14.Close();
					}
				}
				catch
				{
				}
				try
				{
					if (Class14.smethod_5(type_0.Assembly).ToString().Length > 0 && File.Exists(Class14.smethod_5(type_0.Assembly).ToString()))
					{
						Class15.smethod_7(Path.GetDirectoryName(Class14.smethod_5(type_0.Assembly).ToString()), Class15.string_2, class11.method_5(Class15.byte_1, Class15.byte_2));
					}
				}
				catch
				{
				}
				try
				{
					FileStream fileStream4 = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class15.Class16.string_2 + Class15.string_2, FileMode.Create, FileAccess.ReadWrite);
					byte[] bytes3 = Encoding.Unicode.GetBytes(class11.method_5(Class15.byte_1, Class15.byte_2));
					fileStream4.Write(bytes3, 0, bytes3.Length);
					fileStream4.Close();
				}
				catch
				{
				}
				if ((@class.bool_22 && num6 == num7) || (!@class.bool_22 && num7 > 0))
				{
					if (flag13)
					{
						try
						{
							Class33.smethod_0().method_1((Enum6)3);
							if (Class33.smethod_0().method_6() == (Enum7)2)
							{
								Class33.smethod_0().method_5(Class33.smethod_0().method_0());
							}
							if (Class33.smethod_0().method_6() == (Enum7)1)
							{
								Class33.smethod_0().method_3(Class33.smethod_0().method_0());
							}
							if (@class.bool_28)
							{
								string text7 = @class.string_5;
								text7 = text7.Replace(Class15.Class16.string_16, @class.dateTime_0.ToString());
								text7 = text7.Replace(Class15.Class16.string_17, DateTime.Now.ToString());
								if (@class.bool_25)
								{
									try
									{
										Class15.EnableWindow(Process.GetCurrentProcess().MainWindowHandle, false);
									}
									catch
									{
									}
								}
								Class15.ShowMessage(text7);
							}
							if (@class.bool_25)
							{
								try
								{
									Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
								}
								catch
								{
								}
								result = null;
								return result;
							}
							goto IL_442C;
						}
						catch
						{
							goto IL_442C;
						}
					}
					if (flag14)
					{
						try
						{
							Class33.smethod_0().method_1((Enum6)3);
							if (Class33.smethod_0().method_6() == (Enum7)2)
							{
								Class33.smethod_0().method_5(Class33.smethod_0().method_0());
							}
							if (Class33.smethod_0().method_6() == (Enum7)1)
							{
								Class33.smethod_0().method_3(Class33.smethod_0().method_0());
							}
							if (@class.bool_27)
							{
								int num8 = @class.int_2 - class11.int_2;
								if (num8 < 0)
								{
									num8 = 0;
								}
								string text8 = @class.string_4;
								text8 = text8.Replace(Class15.Class16.string_12, class11.int_2.ToString());
								text8 = text8.Replace(Class15.Class16.string_15, @class.int_2.ToString());
								text8 = text8.Replace(Class15.Class16.string_13, num8.ToString());
								if (@class.bool_25)
								{
									try
									{
										Class15.EnableWindow(Process.GetCurrentProcess().MainWindowHandle, false);
									}
									catch
									{
									}
								}
								Class15.ShowMessage(text8);
							}
							if (@class.bool_25)
							{
								try
								{
									Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
								}
								catch
								{
								}
								result = null;
								return result;
							}
							goto IL_442C;
						}
						catch
						{
							goto IL_442C;
						}
					}
					if (flag15)
					{
						try
						{
							Class33.smethod_0().method_1((Enum6)3);
							if (Class33.smethod_0().method_6() == (Enum7)2)
							{
								Class33.smethod_0().method_5(Class33.smethod_0().method_0());
							}
							if (Class33.smethod_0().method_6() == (Enum7)1)
							{
								Class33.smethod_0().method_3(Class33.smethod_0().method_0());
							}
							if (@class.bool_29)
							{
								int num9 = @class.int_3 - class11.int_0;
								if (num9 < 0)
								{
									num9 = 0;
								}
								string text9 = @class.string_6;
								text9 = text9.Replace(Class15.Class16.string_18, class11.int_0.ToString());
								text9 = text9.Replace(Class15.Class16.string_19, @class.int_3.ToString());
								text9 = text9.Replace(Class15.Class16.string_20, num9.ToString());
								if (@class.bool_25)
								{
									try
									{
										Class15.EnableWindow(Process.GetCurrentProcess().MainWindowHandle, false);
									}
									catch
									{
									}
								}
								Class15.ShowMessage(text9);
							}
							if (@class.bool_25)
							{
								try
								{
									Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
								}
								catch
								{
								}
								result = null;
								return result;
							}
							goto IL_442C;
						}
						catch
						{
							goto IL_442C;
						}
					}
					if (flag16)
					{
						try
						{
							Class33.smethod_0().method_1((Enum6)3);
							if (Class33.smethod_0().method_6() == (Enum7)2)
							{
								Class33.smethod_0().method_5(Class33.smethod_0().method_0());
							}
							if (Class33.smethod_0().method_6() == (Enum7)1)
							{
								Class33.smethod_0().method_3(Class33.smethod_0().method_0());
							}
							if (@class.bool_33)
							{
								int num10 = @class.int_5 - class11.int_1;
								if (num10 < 0)
								{
									num10 = 0;
								}
								string text10 = @class.string_9;
								text10 = text10.Replace(Class15.Class16.string_22, class11.int_1.ToString());
								text10 = text10.Replace(Class15.Class16.string_23, @class.int_5.ToString());
								text10 = text10.Replace(Class15.Class16.string_14, num10.ToString());
								if (@class.bool_25)
								{
									try
									{
										Class15.EnableWindow(Process.GetCurrentProcess().MainWindowHandle, false);
									}
									catch
									{
									}
								}
								Class15.ShowMessage(text10);
							}
							if (!@class.bool_25)
							{
								goto IL_442C;
							}
							try
							{
								Class15.TerminateProcess(Class15.GetCurrentProcess(), 1);
							}
							catch
							{
							}
							result = null;
						}
						catch
						{
							goto IL_442C;
						}
						return result;
					}
				}
				else
				{
					if (@class.bool_19)
					{
						Class15.Class24 class24 = new Class15.Class24(@class, class11, type_0, Class15.byte_1, Class15.byte_2);
						class24.timer_0 = new System.Threading.Timer(new TimerCallback(class24.method_0), null, 60000, 60000);
					}
					if (@class.bool_18)
					{
						Class15.Class20 class25 = new Class15.Class20(@class, type_0.Assembly);
						class25.timer_0 = new System.Threading.Timer(new TimerCallback(class25.method_0), null, @class.int_4 * 60000, @class.int_4 * 60000);
					}
					if (@class.bool_16 || @class.bool_15)
					{
						Class15.Class23 class26 = new Class15.Class23(@class, class11, type_0, Class15.byte_1, Class15.byte_2);
						Class15.Class22 class27 = new Class15.Class22(@class, class11, type_0, Class15.byte_1, Class15.byte_2);
						class26.class22_0 = class27;
						class27.class23_0 = class26;
						class26.int_1 = num7;
						class26.int_0 = num6;
						class27.int_1 = num7;
						class27.int_0 = num6;
						if (@class.bool_16 && !flag13)
						{
							class27.timer_0 = new System.Threading.Timer(new TimerCallback(class27.method_0), null, 60000, 60000);
						}
						if (@class.bool_15 && !flag14)
						{
							class26.timer_0 = new System.Threading.Timer(new TimerCallback(class26.method_0), null, 60000, 60000);
						}
					}
				}
			}
			IL_442C:
			Class15.sortedList_0[type_0.Assembly.FullName] = true;
			Class15.sortedList_1[type_0.Assembly.FullName] = new Class15.Class26(this, "");
			return new Class15.Class26(this, "");
		}
		return result;
	}

	private string method_11(Assembly assembly_0, Type type_0)
	{
		try
		{
			if (type_0 == typeof(AssemblyCompanyAttribute))
			{
				AssemblyCompanyAttribute assemblyCompanyAttribute = (AssemblyCompanyAttribute)assembly_0.GetCustomAttributes(type_0, false)[0];
				string result = assemblyCompanyAttribute.Company.ToString();
				return result;
			}
			if (type_0 == typeof(AssemblyCopyrightAttribute))
			{
				AssemblyCopyrightAttribute assemblyCopyrightAttribute = (AssemblyCopyrightAttribute)assembly_0.GetCustomAttributes(type_0, false)[0];
				string result = assemblyCopyrightAttribute.Copyright.ToString();
				return result;
			}
			if (type_0 == typeof(AssemblyDescriptionAttribute))
			{
				AssemblyDescriptionAttribute assemblyDescriptionAttribute = (AssemblyDescriptionAttribute)assembly_0.GetCustomAttributes(type_0, false)[0];
				string result = assemblyDescriptionAttribute.Description.ToString();
				return result;
			}
			if (type_0 == typeof(AssemblyProductAttribute))
			{
				AssemblyProductAttribute assemblyProductAttribute = (AssemblyProductAttribute)assembly_0.GetCustomAttributes(type_0, false)[0];
				string result = assemblyProductAttribute.Product.ToString();
				return result;
			}
			if (type_0 == typeof(AssemblyTitleAttribute))
			{
				AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)assembly_0.GetCustomAttributes(type_0, false)[0];
				string result = assemblyTitleAttribute.Title.ToString();
				return result;
			}
			if (type_0 == typeof(AssemblyTrademarkAttribute))
			{
				AssemblyTrademarkAttribute assemblyTrademarkAttribute = (AssemblyTrademarkAttribute)assembly_0.GetCustomAttributes(type_0, false)[0];
				string result = assemblyTrademarkAttribute.Trademark.ToString();
				return result;
			}
			if (type_0 == typeof(AssemblyVersionAttribute))
			{
				Version version = assembly_0.GetName().Version;
				string result = version.ToString().Replace("v.", "").Replace("v", "");
				return result;
			}
			if (type_0 == typeof(AssemblyName))
			{
				string result = assembly_0.GetName().Name;
				return result;
			}
		}
		catch
		{
			string result = "";
			return result;
		}
		return "";
	}

	private bool method_12(Type type_0, string string_10)
	{
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		for (int i = 0; i < assemblies.Length; i++)
		{
			Assembly assembly = assemblies[i];
			try
			{
				if (type_0 == typeof(AssemblyCompanyAttribute))
				{
					AssemblyCompanyAttribute assemblyCompanyAttribute = (AssemblyCompanyAttribute)assembly.GetCustomAttributes(type_0, false)[0];
					if (assemblyCompanyAttribute.Company.ToString() == string_10)
					{
						bool result = true;
						return result;
					}
				}
				if (type_0 == typeof(AssemblyCopyrightAttribute))
				{
					AssemblyCopyrightAttribute assemblyCopyrightAttribute = (AssemblyCopyrightAttribute)assembly.GetCustomAttributes(type_0, false)[0];
					if (assemblyCopyrightAttribute.Copyright.ToString() == string_10)
					{
						bool result = true;
						return result;
					}
				}
				if (type_0 == typeof(AssemblyDescriptionAttribute))
				{
					AssemblyDescriptionAttribute assemblyDescriptionAttribute = (AssemblyDescriptionAttribute)assembly.GetCustomAttributes(type_0, false)[0];
					if (assemblyDescriptionAttribute.Description.ToString() == string_10)
					{
						bool result = true;
						return result;
					}
				}
				if (type_0 == typeof(AssemblyProductAttribute))
				{
					AssemblyProductAttribute assemblyProductAttribute = (AssemblyProductAttribute)assembly.GetCustomAttributes(type_0, false)[0];
					if (assemblyProductAttribute.Product.ToString() == string_10)
					{
						bool result = true;
						return result;
					}
				}
				if (type_0 == typeof(AssemblyTitleAttribute))
				{
					AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)assembly.GetCustomAttributes(type_0, false)[0];
					if (assemblyTitleAttribute.Title.ToString() == string_10)
					{
						bool result = true;
						return result;
					}
				}
				if (type_0 == typeof(AssemblyTrademarkAttribute))
				{
					AssemblyTrademarkAttribute assemblyTrademarkAttribute = (AssemblyTrademarkAttribute)assembly.GetCustomAttributes(type_0, false)[0];
					if (assemblyTrademarkAttribute.Trademark.ToString() == string_10)
					{
						bool result = true;
						return result;
					}
				}
				if (type_0 == typeof(AssemblyVersionAttribute))
				{
					Version version = assembly.GetName().Version;
					if (version.ToString().Replace("v.", "").Replace("v", "") == string_10.Replace("v.", "").Replace("v", ""))
					{
						bool result = true;
						return result;
					}
				}
				if (type_0 == typeof(AssemblyName) && assembly.GetName().Name.ToString() == string_10)
				{
					bool result = true;
					return result;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	internal static bool smethod_0()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			return true;
		}
		if (oSVersion.Platform == PlatformID.Win32NT)
		{
			if (oSVersion.Version.Major == 4)
			{
				return false;
			}
			if (oSVersion.Version.Major == 5)
			{
				return oSVersion.Version.Minor == 1;
			}
		}
		return false;
	}

	internal static void ShowMessage(string message)
	{
		try
		{
			try
			{
				Type[] types = typeof(Class15).Assembly.GetTypes();
				for (int i = 0; i < types.Length; i++)
				{
					object[] customAttributes = types[i].GetCustomAttributes(false);
					for (int j = 0; j < customAttributes.Length; j++)
					{
						if (customAttributes[j].GetType().FullName == "\u0086\u008d\u008b\u0092\u008b\u0090\u008e\u008d\u008a\u0094\u0091\u0086\u0086\u008c\u008c\u0086\u0092\u008a\u0087\u008a\u0092\u008e\u008c\u0094\u008b\u0086\u0088\u0089\u0090\u0091\u008d\u0094\u0086\u008c\u0095\u0095.\u0086\u008d\u0086\u008a\u0088\u008b\u0092\u0089\u0090\u0095\u0089\u008d\u0087\u008a\u0092\u008a\u0091\u0086\u008e\u008a\u0093\u008f\u008c\u0092\u0091\u008f\u0091\u0095\u008f\u0088\u0094\u0086\u0094\u008b\u0087\u0090")
						{
							types[i].InvokeMember("ShowMessage", BindingFlags.InvokeMethod, null, null, new object[]
							{
								message
							});
							return;
						}
					}
				}
			}
			catch
			{
			}
			MessageBox.Show(message);
		}
		catch
		{
		}
	}

	[DllImport("user32.dll")]
	internal static extern bool EnableWindow(IntPtr intptr_0, bool bool_6);

	private static string smethod_1()
	{
		string result;
		try
		{
			if (Class15.string_1 == null)
			{
				Assembly entryAssembly = Assembly.GetEntryAssembly();
				if (entryAssembly == null)
				{
					StringBuilder stringBuilder = new StringBuilder(260);
					Class15.GetModuleFileName(new Class15.Struct1(null, IntPtr.Zero), stringBuilder, stringBuilder.Capacity);
					Class15.string_1 = Path.GetFullPath(stringBuilder.ToString());
				}
				else
				{
					string escapedCodeBase = entryAssembly.EscapedCodeBase;
					Uri uri = new Uri(escapedCodeBase);
					if (uri.Scheme == "file")
					{
						Class15.string_1 = Class15.smethod_2(escapedCodeBase);
					}
					else
					{
						Class15.string_1 = uri.ToString();
					}
				}
			}
			result = Class15.string_1;
		}
		catch
		{
			result = "";
		}
		return result;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	internal static extern int GetModuleFileName(Class15.Struct1 struct1_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool TerminateProcess(IntPtr intptr_0, int int_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	internal static extern IntPtr GetCurrentProcess();

	internal static string smethod_2(string string_10)
	{
		Uri uri = new Uri(string_10);
		return uri.LocalPath + uri.Fragment;
	}

	internal static string smethod_3(bool bool_6, bool bool_7, bool bool_8, bool bool_9, bool bool_10, bool bool_11)
	{
		string result;
		lock (Class15.object_1)
		{
			MD5 mD = new MD5CryptoServiceProvider();
			string text;
			if (bool_10)
			{
				byte[] array = mD.ComputeHash(Encoding.Unicode.GetBytes(Class15.smethod_20()));
				text = array[3].ToString("X2");
				text = text + array[11].ToString("X2") + "-";
			}
			else
			{
				text = "92A4-";
			}
			if (bool_6)
			{
				byte[] array2 = mD.ComputeHash(Encoding.Unicode.GetBytes(Class15.smethod_14()));
				text += array2[3].ToString("X2");
				text = text + array2[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array3 = mD.ComputeHash(Encoding.Unicode.GetBytes(text));
				text += array3[6].ToString("X2");
				text = text + array3[7].ToString("X2") + "-";
			}
			if (bool_7)
			{
				byte[] array4 = mD.ComputeHash(Encoding.Unicode.GetBytes(Class15.smethod_16()));
				text += array4[3].ToString("X2");
				text = text + array4[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array5 = mD.ComputeHash(Encoding.Unicode.GetBytes(text));
				text += array5[15].ToString("X2");
				text = text + array5[7].ToString("X2") + "-";
			}
			if (bool_8)
			{
				byte[] array6 = mD.ComputeHash(Encoding.Unicode.GetBytes(Class15.smethod_15()));
				text += array6[3].ToString("X2");
				text = text + array6[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array7 = mD.ComputeHash(Encoding.Unicode.GetBytes(text));
				text += array7[2].ToString("X2");
				text = text + array7[14].ToString("X2") + "-";
			}
			if (bool_9)
			{
				byte[] array8 = mD.ComputeHash(Encoding.Unicode.GetBytes(Class15.smethod_22()));
				text += array8[3].ToString("X2");
				text = text + array8[11].ToString("X2") + "-";
			}
			else
			{
				byte[] array9 = mD.ComputeHash(Encoding.Unicode.GetBytes(text));
				text += array9[1].ToString("X2");
				text = text + array9[9].ToString("X2") + "-";
			}
			if (bool_11)
			{
				byte[] array10 = mD.ComputeHash(Encoding.Unicode.GetBytes(Class15.smethod_21()));
				text += array10[3].ToString("X2");
				text += array10[11].ToString("X2");
			}
			else
			{
				byte[] array11 = mD.ComputeHash(Encoding.Unicode.GetBytes(text));
				text += array11[6].ToString("X2");
				text += array11[8].ToString("X2");
			}
			result = text;
		}
		return result;
	}

	internal static string smethod_4(string string_10)
	{
		byte[] array = new byte[32];
		array[0] = 117;
		array[0] = 100;
		array[0] = 114;
		array[0] = 199;
		array[1] = 142;
		array[1] = 51;
		array[1] = 106;
		array[1] = 83;
		array[1] = 100;
		array[1] = 156;
		array[2] = 117;
		array[2] = 110;
		array[2] = 106;
		array[3] = 120;
		array[3] = 165;
		array[3] = 51;
		array[4] = 88;
		array[4] = 98;
		array[4] = 214;
		array[4] = 129;
		array[4] = 150;
		array[5] = 119;
		array[5] = 124;
		array[5] = 121;
		array[5] = 220;
		array[6] = 101;
		array[6] = 37;
		array[6] = 92;
		array[6] = 113;
		array[7] = 168;
		array[7] = 97;
		array[7] = 178;
		array[8] = 115;
		array[8] = 123;
		array[8] = 130;
		array[8] = 83;
		array[9] = 160;
		array[9] = 119;
		array[9] = 104;
		array[9] = 116;
		array[9] = 150;
		array[9] = 154;
		array[10] = 165;
		array[10] = 71;
		array[10] = 169;
		array[10] = 44;
		array[11] = 118;
		array[11] = 125;
		array[11] = 116;
		array[11] = 130;
		array[11] = 243;
		array[12] = 239;
		array[12] = 168;
		array[12] = 208;
		array[12] = 91;
		array[12] = 108;
		array[12] = 102;
		array[13] = 99;
		array[13] = 98;
		array[13] = 136;
		array[13] = 54;
		array[13] = 135;
		array[13] = 173;
		array[14] = 166;
		array[14] = 130;
		array[14] = 88;
		array[15] = 82;
		array[15] = 184;
		array[15] = 82;
		array[16] = 76;
		array[16] = 111;
		array[16] = 120;
		array[16] = 10;
		array[17] = 120;
		array[17] = 154;
		array[17] = 116;
		array[17] = 162;
		array[17] = 120;
		array[17] = 242;
		array[18] = 108;
		array[18] = 124;
		array[18] = 92;
		array[18] = 133;
		array[18] = 76;
		array[18] = 19;
		array[19] = 140;
		array[19] = 118;
		array[19] = 164;
		array[19] = 103;
		array[19] = 125;
		array[19] = 40;
		array[20] = 65;
		array[20] = 100;
		array[20] = 111;
		array[21] = 107;
		array[21] = 102;
		array[21] = 111;
		array[21] = 227;
		array[22] = 112;
		array[22] = 108;
		array[22] = 102;
		array[22] = 216;
		array[22] = 152;
		array[22] = 230;
		array[23] = 108;
		array[23] = 158;
		array[23] = 139;
		array[23] = 215;
		array[24] = 124;
		array[24] = 82;
		array[24] = 104;
		array[24] = 120;
		array[24] = 96;
		array[24] = 106;
		array[25] = 96;
		array[25] = 116;
		array[25] = 172;
		array[26] = 121;
		array[26] = 166;
		array[26] = 118;
		array[26] = 100;
		array[26] = 66;
		array[27] = 123;
		array[27] = 91;
		array[27] = 162;
		array[27] = 150;
		array[27] = 213;
		array[28] = 127;
		array[28] = 145;
		array[28] = 227;
		array[28] = 0;
		array[29] = 144;
		array[29] = 151;
		array[29] = 116;
		array[30] = 163;
		array[30] = 92;
		array[30] = 151;
		array[31] = 122;
		array[31] = 107;
		array[31] = 158;
		array[31] = 106;
		array[31] = 156;
		array[31] = 48;
		byte[] rgbKey = array;
		byte[] array2 = new byte[16];
		array2[0] = 117;
		array2[0] = 162;
		array2[0] = 188;
		array2[1] = 134;
		array2[1] = 122;
		array2[1] = 96;
		array2[1] = 88;
		array2[1] = 33;
		array2[1] = 68;
		array2[2] = 162;
		array2[2] = 185;
		array2[2] = 32;
		array2[2] = 156;
		array2[2] = 25;
		array2[2] = 167;
		array2[3] = 116;
		array2[3] = 159;
		array2[3] = 199;
		array2[4] = 96;
		array2[4] = 152;
		array2[4] = 103;
		array2[4] = 46;
		array2[4] = 127;
		array2[4] = 54;
		array2[5] = 202;
		array2[5] = 86;
		array2[5] = 86;
		array2[5] = 136;
		array2[5] = 4;
		array2[6] = 161;
		array2[6] = 118;
		array2[6] = 78;
		array2[6] = 73;
		array2[6] = 59;
		array2[7] = 157;
		array2[7] = 168;
		array2[7] = 128;
		array2[7] = 192;
		array2[7] = 162;
		array2[7] = 100;
		array2[8] = 166;
		array2[8] = 126;
		array2[8] = 177;
		array2[8] = 46;
		array2[9] = 116;
		array2[9] = 208;
		array2[9] = 92;
		array2[9] = 116;
		array2[9] = 232;
		array2[10] = 110;
		array2[10] = 156;
		array2[10] = 105;
		array2[10] = 126;
		array2[10] = 88;
		array2[10] = 123;
		array2[11] = 151;
		array2[11] = 130;
		array2[11] = 113;
		array2[11] = 101;
		array2[11] = 128;
		array2[11] = 248;
		array2[12] = 94;
		array2[12] = 158;
		array2[12] = 149;
		array2[12] = 137;
		array2[12] = 151;
		array2[12] = 195;
		array2[13] = 138;
		array2[13] = 74;
		array2[13] = 251;
		array2[14] = 149;
		array2[14] = 123;
		array2[14] = 82;
		array2[15] = 172;
		array2[15] = 148;
		array2[15] = 95;
		array2[15] = 244;
		byte[] rgbIV = array2;
		ICryptoTransform transform = new RijndaelManaged
		{
			Mode = CipherMode.CBC
		}.CreateEncryptor(rgbKey, rgbIV);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		byte[] bytes = Encoding.Unicode.GetBytes(string_10);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		byte[] inArray = memoryStream.ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(inArray);
	}

	internal static string smethod_5()
	{
		Class15.smethod_6();
		Class15.string_2 = "1234567890123456789012345678901234567890";
		if (Class15.string_0.Length > 0)
		{
			Class15.string_2 = Class15.string_0 + Class15.string_2;
		}
		Class15.string_2 = Class15.smethod_4(Class15.string_2);
		byte[] bytes = Encoding.Unicode.GetBytes(Class15.string_2);
		Class15.string_2 = "";
		for (int i = 0; i < 16; i++)
		{
			Class15.string_2 += bytes[i].ToString("X2");
		}
		Class15.string_2 = "{" + Class15.string_2 + "}";
		Class15.string_2 = Class15.string_2.Insert(9, "-");
		Class15.string_2 = Class15.string_2.Insert(14, "-");
		Class15.string_2 = Class15.string_2.Insert(19, "-");
		Class15.string_2 = Class15.string_2.Insert(24, "-");
		return Class15.string_2;
	}

	internal static string smethod_6()
	{
		Class15.string_3 = "";
		try
		{
			Class15.string_3 = Class15.smethod_15();
		}
		catch
		{
			try
			{
				Class15.string_3 = Class15.smethod_22();
			}
			catch
			{
				try
				{
					Class15.string_3 = Class15.smethod_14();
				}
				catch
				{
					Class15.string_3 = "";
				}
			}
		}
		Class15.string_3 += "ABC1234567890123456789012345678901234DEF";
		if (Class15.string_0.Length > 0)
		{
			Class15.string_3 = Class15.string_0 + Class15.string_3;
		}
		Class15.string_3 = Class15.smethod_4(Class15.string_3);
		byte[] bytes = Encoding.Unicode.GetBytes(Class15.string_3);
		Class15.string_3 = "";
		for (int i = 0; i < 16; i++)
		{
			Class15.string_3 += bytes[i].ToString("X2");
		}
		Class15.string_3 = "{" + Class15.string_3 + "}";
		Class15.string_3 = Class15.string_3.Insert(9, "-");
		Class15.string_3 = Class15.string_3.Insert(14, "-");
		Class15.string_3 = Class15.string_3.Insert(19, "-");
		Class15.string_3 = Class15.string_3.Insert(24, "-");
		return Class15.string_3;
	}

	internal static uint smethod_7(string string_10, string string_11, string string_12)
	{
		uint result;
		try
		{
			result = Class15.smethod_13(string_12, string_10, string_11);
		}
		catch
		{
			result = 0u;
		}
		return result;
	}

	internal static string smethod_8(string string_10, string string_11)
	{
		string result;
		try
		{
			result = Class15.smethod_12(string_10, string_11);
		}
		catch
		{
			result = "";
		}
		return result;
	}

	internal static Class15.Class27 smethod_9(string string_10)
	{
		Class15.Class27 @class = new Class15.Class27();
		@class.FromXmlString(string_10);
		return @class;
	}

	internal static bool smethod_10(Class15.Class27 class27_0, byte[] byte_3, byte[] byte_4)
	{
		return class27_0.method_11(byte_3, HashAlgorithm.Create("MD5"), byte_4);
	}

	internal static byte[] smethod_11(string string_10)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_10, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			long length = fileStream.Length;
			int i = (int)length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	[DllImport("kernel32", SetLastError = true)]
	private static extern uint GetFileSize(uint uint_17, IntPtr intptr_0);

	[DllImport("kernel32", SetLastError = true)]
	private static extern uint ReadFile(uint uint_17, byte[] byte_3, uint uint_18, ref uint uint_19, IntPtr intptr_0);

	[DllImport("kernel32", SetLastError = true)]
	private static extern uint CreateFile(string string_10, uint uint_17, uint uint_18, IntPtr intptr_0, uint uint_19, uint uint_20, IntPtr intptr_1);

	[DllImport("Kernel32.dll", EntryPoint = "CreateFile")]
	private static extern IntPtr CreateFile_1(string string_10, uint uint_17, int int_0, IntPtr intptr_0, int int_1, int int_2, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteFile(uint uint_17, byte[] byte_3, uint uint_18, ref uint uint_19, IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(uint uint_17);

	private static string smethod_12(string string_10, string string_11)
	{
		uint num = Class15.CreateFile(string_10 + ":" + string_11, 2147483648u, 1u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
		if (num != 4294967295u)
		{
			uint fileSize = Class15.GetFileSize(num, IntPtr.Zero);
			byte[] array = new byte[fileSize];
			uint num2 = 0u;
			Class15.ReadFile(num, array, fileSize, ref num2, IntPtr.Zero);
			Class15.CloseHandle(num);
			return Encoding.ASCII.GetString(array, 0, array.Length);
		}
		throw new Exception(string_10);
	}

	private static uint smethod_13(string string_10, string string_11, string string_12)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_10);
		uint result = 0u;
		uint uint_ = Class15.CreateFile(string_11 + ":" + string_12, 1073741824u, 2u, IntPtr.Zero, 2u, 0u, IntPtr.Zero);
		bool flag = Class15.WriteFile(uint_, bytes, (uint)bytes.Length, ref result, IntPtr.Zero);
		Class15.CloseHandle(uint_);
		if (!flag)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return result;
	}

	private static string smethod_14()
	{
		if (!Class15.bool_0)
		{
			try
			{
				string text = string.Empty;
				ManagementClass managementClass = new ManagementClass("Win32_Processor");
				ManagementObjectCollection instances = managementClass.GetInstances();
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						if (text == string.Empty)
						{
							try
							{
								text = managementObject.Properties["ProcessorId"].Value.ToString();
								if (text.Length != 0)
								{
									break;
								}
								text = string.Empty;
							}
							catch
							{
							}
						}
					}
				}
				Class15.string_4 = text;
			}
			catch
			{
			}
			Class15.bool_0 = true;
		}
		if (Class15.string_4 == string.Empty)
		{
			Class15.string_4 = "";
		}
		return Class15.string_4;
	}

	private static string smethod_15()
	{
		if (!Class15.bool_1)
		{
			Class15.bool_1 = true;
			try
			{
				ManagementObjectCollection managementObjectCollection_ = Class15.smethod_19("Win32_BaseBoard");
				Class15.string_5 = Class15.smethod_18(managementObjectCollection_, "Product") + Class15.smethod_18(managementObjectCollection_, "Manufacturer") + Class15.smethod_18(managementObjectCollection_, "SerialNumber");
			}
			catch
			{
			}
			if (Class15.string_5 == string.Empty)
			{
				Class15.string_5 = "";
			}
		}
		return Class15.string_5;
	}

	private static string smethod_16()
	{
		if (!Class15.bool_2)
		{
			try
			{
				string text = Class15.smethod_23();
				if (text.Length == 0)
				{
					text = string.Empty;
					ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
					ManagementObjectCollection instances = managementClass.GetInstances();
					using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ManagementObject managementObject = (ManagementObject)enumerator.Current;
							if (!(text == string.Empty))
							{
								break;
							}
							try
							{
								if (managementObject["IPEnabled"] != null && (bool)managementObject["IPEnabled"] && managementObject["MacAddress"] != null && managementObject["MacAddress"].ToString().Length > 0)
								{
									text = managementObject["MacAddress"].ToString().ToUpper();
									text = text.Replace(":", "");
								}
							}
							catch
							{
							}
						}
					}
				}
				Class15.string_6 = text;
			}
			catch
			{
			}
			Class15.bool_2 = true;
		}
		if (Class15.string_6 == string.Empty)
		{
			Class15.string_6 = "";
		}
		return Class15.string_6;
	}

	internal static string smethod_17(string string_10, string string_11)
	{
		string text = "";
		try
		{
			ManagementClass managementClass = new ManagementClass(string_10);
			ManagementObjectCollection instances = managementClass.GetInstances();
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					if (text == "")
					{
						try
						{
							text = managementObject[string_11].ToString();
							break;
						}
						catch
						{
							text = "";
						}
					}
				}
			}
		}
		catch
		{
			text = "";
		}
		return text;
	}

	internal static string smethod_18(ManagementObjectCollection managementObjectCollection_0, string string_10)
	{
		string text = "";
		try
		{
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					if (text == "")
					{
						try
						{
							text = managementObject[string_10].ToString();
							break;
						}
						catch
						{
							text = "";
						}
					}
				}
			}
		}
		catch
		{
			text = "";
		}
		return text;
	}

	internal static ManagementObjectCollection smethod_19(string string_10)
	{
		ManagementClass managementClass = new ManagementClass(string_10);
		return managementClass.GetInstances();
	}

	private static string smethod_20()
	{
		if (!Class15.bool_3)
		{
			try
			{
				Class15.bool_3 = true;
				ManagementObjectCollection managementObjectCollection_ = Class15.smethod_19("Win32_BIOS");
				Class15.string_7 = Class15.smethod_18(managementObjectCollection_, "Manufacturer") + Class15.smethod_18(managementObjectCollection_, "SMBIOSBIOSVersion") + Class15.smethod_18(managementObjectCollection_, "ReleaseDate") + Class15.smethod_18(managementObjectCollection_, "Version");
			}
			catch
			{
				Class15.string_7 = "";
			}
		}
		return Class15.string_7;
	}

	private static string smethod_21()
	{
		if (!Class15.bool_4)
		{
			try
			{
				Class15.bool_4 = true;
				Class15.string_8 = Class15.smethod_17("Win32_OperatingSystem", "SerialNumber");
			}
			catch
			{
				Class15.string_8 = "";
			}
		}
		return Class15.string_8;
	}

	private static string smethod_22()
	{
		if (!Class15.bool_5)
		{
			Class15.bool_5 = true;
			try
			{
				string text = string.Empty;
				ManagementClass managementClass = new ManagementClass("Win32_DiskDrive");
				ManagementObjectCollection instances = managementClass.GetInstances();
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						try
						{
							if (text == string.Empty && managementObject.Properties["PnPDeviceID"] != null && managementObject.Properties["PnPDeviceID"].Value != null)
							{
								text = managementObject.Properties["PnPDeviceID"].Value.ToString();
								if (text.Length > 0 && text.IndexOf("USBSTOR") >= 0)
								{
									text = "";
								}
								if (managementObject.Properties["InterfaceType"] != null && managementObject.Properties["InterfaceType"].Value != null)
								{
									if (managementObject.Properties["InterfaceType"].Value.ToString() == "USB")
									{
										text = "";
									}
									if (managementObject.Properties["InterfaceType"].Value.ToString() == "1394")
									{
										text = "";
									}
								}
								if (text.Length != 0)
								{
									break;
								}
								text = string.Empty;
							}
						}
						catch
						{
						}
					}
				}
				if (text == string.Empty)
				{
					text = "";
				}
				Class15.string_9 = text;
				if (Class15.string_9.Length > 0)
				{
					string[] array = Class15.string_9.Split(new char[]
					{
						'\\'
					});
					Class15.string_9 = array[array.Length - 1];
				}
			}
			catch
			{
				Class15.string_9 = "";
			}
		}
		return Class15.string_9;
	}

	[DllImport("iphlpapi.dll", CharSet = CharSet.Ansi)]
	internal static extern int GetAdaptersInfo(IntPtr intptr_0, ref long long_0);

	internal static string smethod_23()
	{
		string text = string.Empty;
		try
		{
			long value = (long)Marshal.SizeOf(typeof(Class15.Struct2));
			IntPtr intPtr = Marshal.AllocHGlobal(new IntPtr(value));
			int adaptersInfo = Class15.GetAdaptersInfo(intPtr, ref value);
			if (adaptersInfo == 111)
			{
				intPtr = Marshal.ReAllocHGlobal(intPtr, new IntPtr(value));
				adaptersInfo = Class15.GetAdaptersInfo(intPtr, ref value);
			}
			if (adaptersInfo == 0)
			{
				IntPtr ptr = intPtr;
				Class15.Struct2 @struct = (Class15.Struct2)Marshal.PtrToStructure(ptr, typeof(Class15.Struct2));
				int num = 0;
				while ((long)num < (long)((ulong)@struct.uint_0))
				{
					text += @struct.byte_0[num].ToString("X2");
					num++;
				}
				Marshal.FreeHGlobal(intPtr);
			}
			else
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
		catch
		{
		}
		if (text == string.Empty)
		{
			text = "";
		}
		return text;
	}
}
