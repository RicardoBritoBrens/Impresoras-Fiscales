using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ConsultaRNC.My
{
	[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode, CompilerGenerated]
	internal sealed class InternalXmlHelper
	{
		[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode, CompilerGenerated]
		private sealed class RemoveNamespaceAttributesClosure
		{
			private readonly string[] m_inScopePrefixes;

			private readonly XNamespace[] m_inScopeNs;

			private readonly List<XAttribute> m_attributes;

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal RemoveNamespaceAttributesClosure(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes)
			{
				this.m_inScopePrefixes = inScopePrefixes;
				this.m_inScopeNs = inScopeNs;
				this.m_attributes = attributes;
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal XElement ProcessXElement(XElement elem)
			{
				return InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, elem);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal object ProcessObject(object obj)
			{
				XElement xElement = obj as XElement;
				bool flag = xElement != null;
				object result;
				if (flag)
				{
					result = InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, xElement);
				}
				else
				{
					result = obj;
				}
				return result;
			}
		}

		//public static string Value
		//{
		//	get
		//	{
		//		string result;
		//		try
		//		{
		//			IEnumerator<XElement> enumerator = source.GetEnumerator();
		//			if (enumerator.MoveNext())
		//			{
		//				XElement current = enumerator.Current;
		//				result = current.Value;
		//				return result;
		//			}
		//		}
		//		finally
		//		{
		//			IEnumerator<XElement> enumerator;
		//			bool flag = enumerator != null;
		//			if (flag)
		//			{
		//				enumerator.Dispose();
		//			}
		//		}
		//		result = null;
		//		return result;
		//	}
		//	set
		//	{
		//		try
		//		{
		//			IEnumerator<XElement> enumerator = source.GetEnumerator();
		//			if (enumerator.MoveNext())
		//			{
		//				XElement current = enumerator.Current;
		//				current.Value = value;
		//			}
		//		}
		//		finally
		//		{
		//			IEnumerator<XElement> enumerator;
		//			bool flag = enumerator != null;
		//			if (flag)
		//			{
		//				enumerator.Dispose();
		//			}
		//		}
		//	}
		//}

		//public static string AttributeValue
		//{
		//	get
		//	{
		//		string result;
		//		try
		//		{
		//			IEnumerator<XElement> enumerator = source.GetEnumerator();
		//			if (enumerator.MoveNext())
		//			{
		//				XElement current = enumerator.Current;
		//				result = (string)current.Attribute(name);
		//				return result;
		//			}
		//		}
		//		finally
		//		{
		//			IEnumerator<XElement> enumerator;
		//			bool flag = enumerator != null;
		//			if (flag)
		//			{
		//				enumerator.Dispose();
		//			}
		//		}
		//		result = null;
		//		return result;
		//	}
		//	set
		//	{
		//		try
		//		{
		//			IEnumerator<XElement> enumerator = source.GetEnumerator();
		//			if (enumerator.MoveNext())
		//			{
		//				XElement current = enumerator.Current;
		//				current.SetAttributeValue(name, value);
		//			}
		//		}
		//		finally
		//		{
		//			IEnumerator<XElement> enumerator;
		//			bool flag = enumerator != null;
		//			if (flag)
		//			{
		//				enumerator.Dispose();
		//			}
		//		}
		//	}
		//}

		//public static string AttributeValue
		//{
		//	get
		//	{
		//		return (string)source.Attribute(name);
		//	}
		//	set
		//	{
		//		source.SetAttributeValue(name, value);
		//	}
		//}

		[EditorBrowsable(EditorBrowsableState.Never)]
		private InternalXmlHelper()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XAttribute CreateAttribute(XName name, object value)
		{
			bool flag = value == null;
			XAttribute result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new XAttribute(name, RuntimeHelpers.GetObjectValue(value));
			}
			return result;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
		{
			XAttribute xAttribute = new XAttribute(name, ns.NamespaceName);
			xAttribute.AddAnnotation(ns);
			return xAttribute;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static object RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, object obj)
		{
			bool flag = obj != null;
			object result;
			if (flag)
			{
				XElement xElement = obj as XElement;
				flag = (xElement != null);
				if (flag)
				{
					result = InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, xElement);
					return result;
				}
				IEnumerable enumerable = obj as IEnumerable;
				flag = (enumerable != null);
				if (flag)
				{
					result = InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, enumerable);
					return result;
				}
			}
			result = obj;
			return result;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IEnumerable RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, IEnumerable obj)
		{
			bool flag = obj != null;
			IEnumerable result;
			if (flag)
			{
				IEnumerable<XElement> enumerable = obj as IEnumerable<XElement>;
				flag = (enumerable != null);
				if (flag)
				{
					result = enumerable.Select(new Func<XElement, XElement>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement));
				}
				else
				{
					result = obj.Cast<object>().Select(new Func<object, object>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject));
				}
			}
			else
			{
				result = obj;
			}
			return result;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XElement RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, XElement e)
		{
			bool flag = e != null;
			checked
			{
				if (flag)
				{
					XAttribute nextAttribute;
					for (XAttribute xAttribute = e.FirstAttribute; xAttribute != null; xAttribute = nextAttribute)
					{
						nextAttribute = xAttribute.NextAttribute;
						flag = xAttribute.IsNamespaceDeclaration;
						if (flag)
						{
							XNamespace xNamespace = xAttribute.Annotation<XNamespace>();
							string localName = xAttribute.Name.LocalName;
							flag = (xNamespace != null);
							if (flag)
							{
								bool flag2 = inScopePrefixes != null && inScopeNs != null;
								if (flag2)
								{
									int num = inScopePrefixes.Length - 1;
									int arg_73_0 = 0;
									int num2 = num;
									int num3 = arg_73_0;
									XNamespace right;
									while (true)
									{
										int arg_BD_0 = num3;
										int num4 = num2;
										if (arg_BD_0 > num4)
										{
											goto IL_BF;
										}
										string value = inScopePrefixes[num3];
										right = inScopeNs[num3];
										flag2 = localName.Equals(value);
										if (flag2)
										{
											break;
										}
										num3++;
									}
									flag = (xNamespace == right);
									if (flag)
									{
										xAttribute.Remove();
									}
									xAttribute = null;
								}
								IL_BF:
								flag2 = (xAttribute != null);
								if (flag2)
								{
									flag = (attributes != null);
									bool flag3;
									if (flag)
									{
										int num5 = attributes.Count - 1;
										int arg_EC_0 = 0;
										int num6 = num5;
										int num7 = arg_EC_0;
										XNamespace xNamespace2;
										while (true)
										{
											int arg_15A_0 = num7;
											int num4 = num6;
											if (arg_15A_0 > num4)
											{
												goto IL_15C;
											}
											XAttribute xAttribute2 = attributes[num7];
											string localName2 = xAttribute2.Name.LocalName;
											xNamespace2 = xAttribute2.Annotation<XNamespace>();
											flag2 = (xNamespace2 != null);
											if (flag2)
											{
												flag = localName.Equals(localName2);
												if (flag)
												{
													break;
												}
											}
											num7++;
										}
										flag3 = (xNamespace == xNamespace2);
										if (flag3)
										{
											xAttribute.Remove();
										}
										xAttribute = null;
									}
									IL_15C:
									flag3 = (xAttribute != null);
									if (flag3)
									{
										xAttribute.Remove();
										attributes.Add(xAttribute);
									}
								}
							}
						}
					}
				}
				return e;
			}
		}
	}
}
