﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace ImmutableObjectGraph.Tests {
	using System.Diagnostics;
	using ImmutableObjectGraph;

	
	public interface IEmpty {
	}
	
	public partial class Empty : IEmpty {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Empty DefaultInstance = GetDefaultTemplate();
	
		/// <summary>Initializes a new instance of the Empty class.</summary>
		protected Empty()
		{
		}
	
	
		public static Empty Create() {
			return DefaultInstance;
		}
	
	
	 
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated Empty whose fields are initialized with default values.</summary>
		private static Empty GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new Empty();
		}
	
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {	}
		
		public Builder ToBuilder() {
			return new Builder(this);
		}
		
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Empty immutable;
		
			internal Builder(Empty immutable) {
				this.immutable = immutable;
		
			}
		
			public Empty ToImmutable() {
				return this.immutable = this.immutable;
			}
		}
		
	
	}
	
}


