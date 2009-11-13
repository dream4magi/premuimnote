using System;
using System.Reflection;
using System.Xml;

namespace Xstream.Core.Converters
{
	/// <summary>
	/// Converts a TimeSpan to XML and back.
	/// </summary>
	internal class TimeSpanConverter : IConverter
	{
		private static readonly Type __type = typeof( TimeSpan );

		/// <summary>
		/// Register is called by a MarshalContext to allow the
		/// converter instance to register itself in the context
		/// with all appropriate value types and interfaces.
		/// </summary>
		public void Register(IMarshalContext context)
		{
			context.RegisterConverter( __type, this );
			context.Alias( "timespan", __type );
		}

		/// <summary>
		/// Converts the object passed in to its XML representation.
		/// The XML string is written on the XmlTextWriter.
		/// </summary>
		public void ToXml(object value, FieldInfo field, XmlTextWriter xml, IMarshalContext context)
		{
			context.WriteStartTag( __type, field, xml );
			xml.WriteString( ( (TimeSpan) value ).Ticks.ToString() );
			context.WriteEndTag( __type, field, xml );
		}

		/// <summary>
		/// Converts the XmlNode data passed in back to an actual
		/// .NET instance object.
		/// </summary>
		/// <returns>Object created from the XML.</returns>
		public object FromXml(object parent, FieldInfo field, Type type, XmlNode xml, IMarshalContext context)
		{
			return TimeSpan.FromTicks( long.Parse( xml.InnerText ) );
		}
	}
}
