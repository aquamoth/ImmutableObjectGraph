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
	using System.Linq;
	using ImmutableObjectGraph;
	
	public interface IFamily {
		System.Collections.Immutable.ImmutableSortedSet<Person> Members { get; }
	}
	
	public partial class Family : IFamily {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Family DefaultInstance = GetDefaultTemplate();
		
		/// <summary>The last identity assigned to a created instance.</summary>
		private static int lastIdentityProduced;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableSortedSet<Person> members;
	
		private readonly System.Int32 identity;
	
		/// <summary>Initializes a new instance of the Family class.</summary>
		protected Family(
			System.Int32 identity,
			System.Collections.Immutable.ImmutableSortedSet<Person> members)
		{
			this.identity = identity;
			this.members = members;
			this.Validate();
		}
	
		public static Family Create(
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<Person>> members = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<Person>>)) {
			var identity = Optional.For(NewIdentity());
			return DefaultInstance.With(
				members: members.GetValueOrDefault(DefaultInstance.Members),
				identity: identity.GetValueOrDefault(DefaultInstance.Identity));
		}
	
		public System.Collections.Immutable.ImmutableSortedSet<Person> Members {
			get { return this.members; }
		}
		
		/// <summary>Returns a new instance with the Members property set to the specified value.</summary>
		public Family WithMembers(System.Collections.Immutable.ImmutableSortedSet<Person> value) {
			if (value == this.Members) {
				return this;
			}
		
			return this.With(members: value);
		}
		
		/// <summary>Replaces the elements of the Members collection with the specified collection.</summary>
		public Family WithMembers(params Person[] values) {
			return this.With(members: this.Members.ResetContents(values));
		}
		
		/// <summary>Replaces the elements of the Members collection with the specified collection.</summary>
		public Family WithMembers(System.Collections.Generic.IEnumerable<Person> values) {
			return this.With(members: this.Members.ResetContents(values));
		}
		
		/// <summary>Adds the specified elements from the Members collection.</summary>
		public Family AddMembers(System.Collections.Generic.IEnumerable<Person> values) {
			return this.With(members: this.Members.AddRange(values));
		}
		
		/// <summary>Adds the specified elements from the Members collection.</summary>
		public Family AddMembers(params Person[] values) {
			return this.With(members: this.Members.AddRange(values));
		}
		
		/// <summary>Adds the specified element from the Members collection.</summary>
		public Family AddMembers(Person value) {
			return this.With(members: this.Members.Add(value));
		}
		
		/// <summary>Removes the specified elements from the Members collection.</summary>
		public Family RemoveMembers(System.Collections.Generic.IEnumerable<Person> values) {
			return this.With(members: this.Members.RemoveRange(values));
		}
		
		/// <summary>Removes the specified elements from the Members collection.</summary>
		public Family RemoveMembers(params Person[] values) {
			return this.With(members: this.Members.RemoveRange(values));
		}
		
		/// <summary>Removes the specified element from the Members collection.</summary>
		public Family RemoveMembers(Person value) {
			return this.With(members: this.Members.Remove(value));
		}
		
		/// <summary>Clears all elements from the Members collection.</summary>
		public Family RemoveMembers() {
			return this.With(members: this.Members.Clear());
		}
		
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public virtual Family With(
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<Person>> members = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<Person>>),
			ImmutableObjectGraph.Optional<System.Int32> identity = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (
				(identity.IsDefined && identity.Value != this.Identity) || 
				(members.IsDefined && members.Value != this.Members)) {
				return new Family(
					identity: identity.GetValueOrDefault(this.Identity),
					members: members.GetValueOrDefault(this.Members));
			} else {
				return this;
			}
		}
	
		protected internal System.Int32 Identity {
			get { return this.identity; }
		}
	
		/// <summary>Returns a unique identity that may be assigned to a newly created instance.</summary>
		protected static System.Int32 NewIdentity() {
			return System.Threading.Interlocked.Increment(ref lastIdentityProduced);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated Family whose fields are initialized with default values.</summary>
		private static Family GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new Family(
				default(System.Int32), 
				template.Members);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.Collections.Immutable.ImmutableSortedSet<Person> Members { get; set; }
		}
		
		public Builder ToBuilder() {
			return new Builder(this);
		}
		
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Family immutable;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<Person>.Builder> members;
		
			internal Builder(Family immutable) {
				this.immutable = immutable;
		
			}
		
			public System.Collections.Immutable.ImmutableSortedSet<Person>.Builder Members {
				get {
					if (!this.members.IsDefined) {
						this.members = this.immutable.members != null ? this.immutable.members.ToBuilder() : null;
					}
		
					return this.members.Value;
				}
		
				set {
					this.members = value;
				}
			}
		
			public Family ToImmutable() {
				var members = this.members.IsDefined ? (this.members.Value != null ? this.members.Value.ToImmutable() : null) : this.immutable.Members;
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(members));
			}
		}
	}
	
	public interface IPerson {
		System.String Name { get; }
		System.Int32 Age { get; }
		Watch Watch { get; }
	}
	
	public partial class Person : IPerson {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Person DefaultInstance = GetDefaultTemplate();
		
		/// <summary>The last identity assigned to a created instance.</summary>
		private static int lastIdentityProduced;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String name;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 age;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Watch watch;
	
		private readonly System.Int32 identity;
	
		/// <summary>Initializes a new instance of the Person class.</summary>
		protected Person(
			System.Int32 identity,
			System.String name,
			System.Int32 age,
			Watch watch)
		{
			this.identity = identity;
			this.name = name;
			this.age = age;
			this.watch = watch;
			this.Validate();
		}
	
		public static Person Create(
			System.String name,
			ImmutableObjectGraph.Optional<System.Int32> age = default(ImmutableObjectGraph.Optional<System.Int32>),
			ImmutableObjectGraph.Optional<Watch> watch = default(ImmutableObjectGraph.Optional<Watch>)) {
			var identity = Optional.For(NewIdentity());
			return DefaultInstance.With(
				name: name,
				age: age.GetValueOrDefault(DefaultInstance.Age),
				watch: watch.GetValueOrDefault(DefaultInstance.Watch),
				identity: identity.GetValueOrDefault(DefaultInstance.Identity));
		}
	
		public System.String Name {
			get { return this.name; }
		}
	
		public System.Int32 Age {
			get { return this.age; }
		}
	
		public Watch Watch {
			get { return this.watch; }
		}
		
		/// <summary>Returns a new instance with the Name property set to the specified value.</summary>
		public Person WithName(System.String value) {
			if (value == this.Name) {
				return this;
			}
		
			return this.With(name: value);
		}
		
		/// <summary>Returns a new instance with the Age property set to the specified value.</summary>
		public Person WithAge(System.Int32 value) {
			if (value == this.Age) {
				return this;
			}
		
			return this.With(age: value);
		}
		
		/// <summary>Returns a new instance with the Watch property set to the specified value.</summary>
		public Person WithWatch(Watch value) {
			if (value == this.Watch) {
				return this;
			}
		
			return this.With(watch: value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public virtual Person With(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.Int32> age = default(ImmutableObjectGraph.Optional<System.Int32>),
			ImmutableObjectGraph.Optional<Watch> watch = default(ImmutableObjectGraph.Optional<Watch>),
			ImmutableObjectGraph.Optional<System.Int32> identity = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (
				(identity.IsDefined && identity.Value != this.Identity) || 
				(name.IsDefined && name.Value != this.Name) || 
				(age.IsDefined && age.Value != this.Age) || 
				(watch.IsDefined && watch.Value != this.Watch)) {
				return new Person(
					identity: identity.GetValueOrDefault(this.Identity),
					name: name.GetValueOrDefault(this.Name),
					age: age.GetValueOrDefault(this.Age),
					watch: watch.GetValueOrDefault(this.Watch));
			} else {
				return this;
			}
		}
	
		protected internal System.Int32 Identity {
			get { return this.identity; }
		}
	
		/// <summary>Returns a unique identity that may be assigned to a newly created instance.</summary>
		protected static System.Int32 NewIdentity() {
			return System.Threading.Interlocked.Increment(ref lastIdentityProduced);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated Person whose fields are initialized with default values.</summary>
		private static Person GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new Person(
				default(System.Int32), 
				template.Name, 
				template.Age, 
				template.Watch);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.String Name { get; set; }
	
			internal System.Int32 Age { get; set; }
	
			internal Watch Watch { get; set; }
		}
		
		public Builder ToBuilder() {
			return new Builder(this);
		}
		
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Person immutable;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.String name;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.Int32 age;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<Watch.Builder> watch;
		
			internal Builder(Person immutable) {
				this.immutable = immutable;
		
				this.name = immutable.Name;
				this.age = immutable.Age;
			}
		
			public System.String Name {
				get {
					return this.name;
				}
		
				set {
					this.name = value;
				}
			}
		
			public System.Int32 Age {
				get {
					return this.age;
				}
		
				set {
					this.age = value;
				}
			}
		
			public Watch.Builder Watch {
				get {
					if (!this.watch.IsDefined) {
						this.watch = this.immutable.watch != null ? this.immutable.watch.ToBuilder() : null;
					}
		
					return this.watch.Value;
				}
		
				set {
					this.watch = value;
				}
			}
		
			public Person ToImmutable() {
				var watch = this.watch.IsDefined ? (this.watch.Value != null ? this.watch.Value.ToImmutable() : null) : this.immutable.Watch;
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.Name),
					ImmutableObjectGraph.Optional.For(this.Age),
					ImmutableObjectGraph.Optional.For(watch));
			}
		}
	}
	
	public interface IWatch {
		System.String Color { get; }
		System.Int32 Size { get; }
	}
	
	public partial class Watch : IWatch {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Watch DefaultInstance = GetDefaultTemplate();
		
		/// <summary>The last identity assigned to a created instance.</summary>
		private static int lastIdentityProduced;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String color;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 size;
	
		private readonly System.Int32 identity;
	
		/// <summary>Initializes a new instance of the Watch class.</summary>
		protected Watch(
			System.Int32 identity,
			System.String color,
			System.Int32 size)
		{
			this.identity = identity;
			this.color = color;
			this.size = size;
			this.Validate();
		}
	
		public static Watch Create(
			ImmutableObjectGraph.Optional<System.String> color = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.Int32> size = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			var identity = Optional.For(NewIdentity());
			return DefaultInstance.With(
				color: color.GetValueOrDefault(DefaultInstance.Color),
				size: size.GetValueOrDefault(DefaultInstance.Size),
				identity: identity.GetValueOrDefault(DefaultInstance.Identity));
		}
	
		public System.String Color {
			get { return this.color; }
		}
	
		public System.Int32 Size {
			get { return this.size; }
		}
		
		/// <summary>Returns a new instance with the Color property set to the specified value.</summary>
		public Watch WithColor(System.String value) {
			if (value == this.Color) {
				return this;
			}
		
			return this.With(color: value);
		}
		
		/// <summary>Returns a new instance with the Size property set to the specified value.</summary>
		public Watch WithSize(System.Int32 value) {
			if (value == this.Size) {
				return this;
			}
		
			return this.With(size: value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public virtual Watch With(
			ImmutableObjectGraph.Optional<System.String> color = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.Int32> size = default(ImmutableObjectGraph.Optional<System.Int32>),
			ImmutableObjectGraph.Optional<System.Int32> identity = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (
				(identity.IsDefined && identity.Value != this.Identity) || 
				(color.IsDefined && color.Value != this.Color) || 
				(size.IsDefined && size.Value != this.Size)) {
				return new Watch(
					identity: identity.GetValueOrDefault(this.Identity),
					color: color.GetValueOrDefault(this.Color),
					size: size.GetValueOrDefault(this.Size));
			} else {
				return this;
			}
		}
	
		protected internal System.Int32 Identity {
			get { return this.identity; }
		}
	
		/// <summary>Returns a unique identity that may be assigned to a newly created instance.</summary>
		protected static System.Int32 NewIdentity() {
			return System.Threading.Interlocked.Increment(ref lastIdentityProduced);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated Watch whose fields are initialized with default values.</summary>
		private static Watch GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new Watch(
				default(System.Int32), 
				template.Color, 
				template.Size);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.String Color { get; set; }
	
			internal System.Int32 Size { get; set; }
		}
		
		public Builder ToBuilder() {
			return new Builder(this);
		}
		
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Watch immutable;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.String color;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.Int32 size;
		
			internal Builder(Watch immutable) {
				this.immutable = immutable;
		
				this.color = immutable.Color;
				this.size = immutable.Size;
			}
		
			public System.String Color {
				get {
					return this.color;
				}
		
				set {
					this.color = value;
				}
			}
		
			public System.Int32 Size {
				get {
					return this.size;
				}
		
				set {
					this.size = value;
				}
			}
		
			public Watch ToImmutable() {
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.Color),
					ImmutableObjectGraph.Optional.For(this.Size));
			}
		}
	}
}


