// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#pragma warning disable IDE0028, IDE0090, IDE0130, IDE0300, IDE0303, IDE1006, CS8602, CS8604

// Borrowed from System.Text.Json unit tests

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace STJsonAVRepro;

public interface ITestClass
{
    void Initialize();
}

public enum SampleEnumByte : byte
{
    MinZero = byte.MinValue,
    One = 1,
    Two = 2,
    Max = byte.MaxValue
}

public enum SampleEnumSByte : sbyte
{
    MinNegative = sbyte.MinValue,
    Zero = 0,
    One = 1,
    Two = 2,
    Max = sbyte.MaxValue
}

public enum SampleEnum
{
    MinZero = 0,
    One = 1,
    Two = 2
}

public enum SampleEnumInt16 : short
{
    MinNegative = short.MinValue,
    Zero = 0,
    One = 1,
    Two = 2,
    Max = short.MaxValue
}

public enum SampleEnumUInt16 : ushort
{
    MinZero = ushort.MinValue,
    One = 1,
    Two = 2,
    Max = ushort.MaxValue
}

public enum SampleEnumInt32 : int
{
    MinNegative = int.MinValue,
    Zero = 0,
    One = 1,
    Two = 2,
    Max = int.MaxValue
}

public enum SampleEnumUInt32 : uint
{
    MinZero = uint.MinValue,
    One = 1,
    Two = 2,
    Max = uint.MaxValue
}

public enum SampleEnumInt64 : long
{
    MinNegative = long.MinValue,
    Zero = 0,
    One = 1,
    Two = 2,
    Max = long.MaxValue
}

public enum SampleEnumUInt64 : ulong
{
    MinZero = ulong.MinValue,
    One = 1,
    Two = 2,
    Max = ulong.MaxValue
}

public struct SimpleStruct
{
    public int One { get; set; }
    public double Two { get; set; }
}

public struct SimpleTestStruct : ITestClass
{
    public short MyInt16 { get; set; }
    public int MyInt32 { get; set; }
    public long MyInt64 { get; set; }
    public ushort MyUInt16 { get; set; }
    public uint MyUInt32 { get; set; }
    public ulong MyUInt64 { get; set; }
    public byte MyByte { get; set; }
    public sbyte MySByte { get; set; }
    public char MyChar { get; set; }
    public string? MyString { get; set; }
    public decimal MyDecimal { get; set; }
    public bool MyBooleanTrue { get; set; }
    public bool MyBooleanFalse { get; set; }
    public float MySingle { get; set; }
    public double MyDouble { get; set; }
    public DateTime MyDateTime { get; set; }
    public DateTimeOffset MyDateTimeOffset { get; set; }
    public SampleEnum MyEnum { get; set; }
    public SampleEnumInt64 MyInt64Enum { get; set; }
    public SampleEnumUInt64 MyUInt64Enum { get; set; }
    public SimpleStruct MySimpleStruct { get; set; }
    public SimpleTestClass? MySimpleTestClass { get; set; }
    public short[]? MyInt16Array { get; set; }
    public int[]? MyInt32Array { get; set; }
    public long[]? MyInt64Array { get; set; }
    public ushort[]? MyUInt16Array { get; set; }
    public uint[]? MyUInt32Array { get; set; }
    public ulong[]? MyUInt64Array { get; set; }
    public byte[]? MyByteArray { get; set; }
    public sbyte[]? MySByteArray { get; set; }
    public char[]? MyCharArray { get; set; }
    public string[]? MyStringArray { get; set; }
    public decimal[]? MyDecimalArray { get; set; }
    public bool[]? MyBooleanTrueArray { get; set; }
    public bool[]? MyBooleanFalseArray { get; set; }
    public float[]? MySingleArray { get; set; }
    public double[]? MyDoubleArray { get; set; }
    public DateTime[]? MyDateTimeArray { get; set; }
    public DateTimeOffset[]? MyDateTimeOffsetArray { get; set; }
    public SampleEnum[]? MyEnumArray { get; set; }
    public List<string>? MyStringList { get; set; }
    public IEnumerable<string>? MyStringIEnumerableT { get; set; }
    public IList<string>? MyStringIListT { get; set; }
    public ICollection<string>? MyStringICollectionT { get; set; }
    public IReadOnlyCollection<string>? MyStringIReadOnlyCollectionT { get; set; }
    public IReadOnlyList<string>? MyStringIReadOnlyListT { get; set; }
    public ISet<string>? MyStringISetT { get; set; }

    public void Initialize()
    {
        MyInt16 = 1;
        MyInt32 = 2;
        MyInt64 = 3;
        MyUInt16 = 4;
        MyUInt32 = 5;
        MyUInt64 = 6;
        MyByte = 7;
        MySByte = 8;
        MyChar = 'a';
        MyString = "Hello";
        MyBooleanTrue = true;
        MyBooleanFalse = false;
        MySingle = 1.1f;
        MyDouble = 2.2d;
        MyDecimal = 3.3m;
        MyDateTime = new DateTime(2019, 1, 30, 12, 1, 2, DateTimeKind.Utc);
        MyDateTimeOffset = new DateTimeOffset(2019, 1, 30, 12, 1, 2, new TimeSpan(1, 0, 0));
        MyEnum = SampleEnum.Two;
        MyInt64Enum = SampleEnumInt64.MinNegative;
        MyUInt64Enum = SampleEnumUInt64.Max;
        MySimpleStruct = new SimpleStruct { One = 11, Two = 1.9999 };

        MyInt16Array = new short[] { 1 };
        MyInt32Array = new int[] { 2 };
        MyInt64Array = new long[] { 3 };
        MyUInt16Array = new ushort[] { 4 };
        MyUInt32Array = new uint[] { 5 };
        MyUInt64Array = new ulong[] { 6 };
        MyByteArray = new byte[] { 7 };
        MySByteArray = new sbyte[] { 8 };
        MyCharArray = new char[] { 'a' };
        MyStringArray = new string[] { "Hello" };
        MyBooleanTrueArray = new bool[] { true };
        MyBooleanFalseArray = new bool[] { false };
        MySingleArray = new float[] { 1.1f };
        MyDoubleArray = new double[] { 2.2d };
        MyDecimalArray = new decimal[] { 3.3m };
        MyDateTimeArray = new DateTime[] { new DateTime(2019, 1, 30, 12, 1, 2, DateTimeKind.Utc) };
        MyDateTimeOffsetArray = new DateTimeOffset[] { new DateTimeOffset(2019, 1, 30, 12, 1, 2, new TimeSpan(1, 0, 0)) };
        MyEnumArray = new SampleEnum[] { SampleEnum.Two };

        MyStringList = new List<string>() { "Hello" };
        MyStringIEnumerableT = new string[] { "Hello" };
        MyStringIListT = new string[] { "Hello" };
        MyStringICollectionT = new string[] { "Hello" };
        MyStringIReadOnlyCollectionT = new string[] { "Hello" };
        MyStringIReadOnlyListT = new string[] { "Hello" };
        MyStringISetT = new HashSet<string> { "Hello" };
    }
}

public class SimpleTestClass : ITestClass
{
    public short MyInt16 { get; set; }
    public int MyInt32 { get; set; }
    public long MyInt64 { get; set; }
    public ushort MyUInt16 { get; set; }
    public uint MyUInt32 { get; set; }
    public ulong MyUInt64 { get; set; }
    public byte MyByte { get; set; }
    public sbyte MySByte { get; set; }
    public char MyChar { get; set; }
    public string? MyString { get; set; }
    public decimal MyDecimal { get; set; }
    public bool MyBooleanTrue { get; set; }
    public bool MyBooleanFalse { get; set; }
    public float MySingle { get; set; }
    public double MyDouble { get; set; }
    public DateTime MyDateTime { get; set; }
    public DateTimeOffset MyDateTimeOffset { get; set; }
    public Guid MyGuid { get; set; }
    public Uri? MyUri { get; set; }
    public SampleEnumSByte MySByteEnum { get; set; }
    public SampleEnumByte MyByteEnum { get; set; }
    public SampleEnum MyEnum { get; set; }
    public SampleEnumInt16 MyInt16Enum { get; set; }
    public SampleEnumInt32 MyInt32Enum { get; set; }
    public SampleEnumInt64 MyInt64Enum { get; set; }
    public SampleEnumUInt16 MyUInt16Enum { get; set; }
    public SampleEnumUInt32 MyUInt32Enum { get; set; }
    public SampleEnumUInt64 MyUInt64Enum { get; set; }
    public SimpleStruct MySimpleStruct { get; set; }
    public SimpleTestStruct MySimpleTestStruct { get; set; }
    public short[]? MyInt16Array { get; set; }
    public int[]? MyInt32Array { get; set; }
    public long[]? MyInt64Array { get; set; }
    public ushort[]? MyUInt16Array { get; set; }
    public uint[]? MyUInt32Array { get; set; }
    public ulong[]? MyUInt64Array { get; set; }
    public byte[]? MyByteArray { get; set; }
    public sbyte[]? MySByteArray { get; set; }
    public char[]? MyCharArray { get; set; }
    public string[]? MyStringArray { get; set; }
    public decimal[]? MyDecimalArray { get; set; }
    public bool[]? MyBooleanTrueArray { get; set; }
    public bool[]? MyBooleanFalseArray { get; set; }
    public float[]? MySingleArray { get; set; }
    public double[]? MyDoubleArray { get; set; }
    public DateTime[]? MyDateTimeArray { get; set; }
    public DateTimeOffset[]? MyDateTimeOffsetArray { get; set; }
    public Guid[]? MyGuidArray { get; set; }
    public Uri[]? MyUriArray { get; set; }
    public SampleEnum[]? MyEnumArray { get; set; }
    public int[][]? MyInt16TwoDimensionArray { get; set; }
    public List<List<int>>? MyInt16TwoDimensionList { get; set; }
    public int[][][]? MyInt16ThreeDimensionArray { get; set; }
    public List<List<List<int>>>? MyInt16ThreeDimensionList { get; set; }
    public List<string>? MyStringList { get; set; }
    public IEnumerable? MyStringIEnumerable { get; set; }
    public IList? MyStringIList { get; set; }
    public ICollection? MyStringICollection { get; set; }
    public IEnumerable<string>? MyStringIEnumerableT { get; set; }
    public IList<string>? MyStringIListT { get; set; }
    public ICollection<string>? MyStringICollectionT { get; set; }
    public IReadOnlyCollection<string>? MyStringIReadOnlyCollectionT { get; set; }
    public IReadOnlyList<string>? MyStringIReadOnlyListT { get; set; }
    public ISet<string>? MyStringISetT { get; set; }
    public KeyValuePair<string, string> MyStringToStringKeyValuePair { get; set; }
    public IDictionary? MyStringToStringIDict { get; set; }
    public Dictionary<string, string>? MyStringToStringGenericDict { get; set; }
    public IDictionary<string, string>? MyStringToStringGenericIDict { get; set; }
    public IReadOnlyDictionary<string, string>? MyStringToStringGenericIReadOnlyDict { get; set; }
    public ImmutableDictionary<string, string>? MyStringToStringImmutableDict { get; set; }
    public IImmutableDictionary<string, string>? MyStringToStringIImmutableDict { get; set; }
    public ImmutableSortedDictionary<string, string>? MyStringToStringImmutableSortedDict { get; set; }
    public Stack<string>? MyStringStackT { get; set; }
    public Queue<string>? MyStringQueueT { get; set; }
    public HashSet<string>? MyStringHashSetT { get; set; }
    public LinkedList<string>? MyStringLinkedListT { get; set; }
    public SortedSet<string>? MyStringSortedSetT { get; set; }
    public IImmutableList<string>? MyStringIImmutableListT { get; set; }
    public IImmutableStack<string>? MyStringIImmutableStackT { get; set; }
    public IImmutableQueue<string>? MyStringIImmutableQueueT { get; set; }
    public IImmutableSet<string>? MyStringIImmutableSetT { get; set; }
    public ImmutableHashSet<string>? MyStringImmutableHashSetT { get; set; }
    public ImmutableList<string>? MyStringImmutableListT { get; set; }
    public ImmutableStack<string>? MyStringImmutableStackT { get; set; }
    public ImmutableQueue<string>? MyStringImmutablQueueT { get; set; }
    public ImmutableSortedSet<string>? MyStringImmutableSortedSetT { get; set; }
    public List<string?>? MyListOfNullString { get; set; }

    public void Initialize()
    {
        MyInt16 = 1;
        MyInt32 = 2;
        MyInt64 = 3;
        MyUInt16 = 4;
        MyUInt32 = 5;
        MyUInt64 = 6;
        MyByte = 7;
        MySByte = 8;
        MyChar = 'a';
        MyString = "Hello";
        MyBooleanTrue = true;
        MyBooleanFalse = false;
        MySingle = 1.1f;
        MyDouble = 2.2d;
        MyDecimal = 3.3m;
        MyDateTime = new DateTime(2019, 1, 30, 12, 1, 2, DateTimeKind.Utc);
        MyDateTimeOffset = new DateTimeOffset(2019, 1, 30, 12, 1, 2, new TimeSpan(1, 0, 0));
        MyGuid = new Guid("1B33498A-7B7D-4DDA-9C13-F6AA4AB449A6");
        MyUri = new Uri("https://github.com/dotnet/runtime");
        MyEnum = SampleEnum.Two;
        MyInt64Enum = SampleEnumInt64.MinNegative;
        MyUInt64Enum = SampleEnumUInt64.Max;
        MyInt16Array = new short[] { 1 };
        MyInt32Array = new int[] { 2 };
        MyInt64Array = new long[] { 3 };
        MyUInt16Array = new ushort[] { 4 };
        MyUInt32Array = new uint[] { 5 };
        MyUInt64Array = new ulong[] { 6 };
        MyByteArray = new byte[] { 7 };
        MySByteArray = new sbyte[] { 8 };
        MyCharArray = new char[] { 'a' };
        MyStringArray = new string[] { "Hello" };
        MyBooleanTrueArray = new bool[] { true };
        MyBooleanFalseArray = new bool[] { false };
        MySingleArray = new float[] { 1.1f };
        MyDoubleArray = new double[] { 2.2d };
        MyDecimalArray = new decimal[] { 3.3m };
        MyDateTimeArray = new DateTime[] { new DateTime(2019, 1, 30, 12, 1, 2, DateTimeKind.Utc) };
        MyDateTimeOffsetArray = new DateTimeOffset[] { new DateTimeOffset(2019, 1, 30, 12, 1, 2, new TimeSpan(1, 0, 0)) };
        MyGuidArray = new Guid[] { new Guid("1B33498A-7B7D-4DDA-9C13-F6AA4AB449A6") };
        MyUriArray = new Uri[] { new Uri("https://github.com/dotnet/runtime") };
        MyEnumArray = new SampleEnum[] { SampleEnum.Two };
        MySimpleStruct = new SimpleStruct { One = 11, Two = 1.9999 };
        MySimpleTestStruct = new SimpleTestStruct { MyInt64 = 64, MyString = "Hello", MyInt32Array = new int[] { 32 } };

        MyInt16TwoDimensionArray = new int[2][];
        MyInt16TwoDimensionArray[0] = new int[] { 10, 11 };
        MyInt16TwoDimensionArray[1] = new int[] { 20, 21 };

        MyInt16TwoDimensionList = new List<List<int>>();
        MyInt16TwoDimensionList.Add(new List<int> { 10, 11 });
        MyInt16TwoDimensionList.Add(new List<int> { 20, 21 });

        MyInt16ThreeDimensionArray = new int[2][][];
        MyInt16ThreeDimensionArray[0] = new int[2][];
        MyInt16ThreeDimensionArray[1] = new int[2][];
        MyInt16ThreeDimensionArray[0][0] = new int[] { 11, 12 };
        MyInt16ThreeDimensionArray[0][1] = new int[] { 13, 14 };
        MyInt16ThreeDimensionArray[1][0] = new int[] { 21, 22 };
        MyInt16ThreeDimensionArray[1][1] = new int[] { 23, 24 };

        MyInt16ThreeDimensionList = new List<List<List<int>>>();
        var list1 = new List<List<int>>();
        MyInt16ThreeDimensionList.Add(list1);
        list1.Add(new List<int> { 11, 12 });
        list1.Add(new List<int> { 13, 14 });
        var list2 = new List<List<int>>();
        MyInt16ThreeDimensionList.Add(list2);
        list2.Add(new List<int> { 21, 22 });
        list2.Add(new List<int> { 23, 24 });

        MyStringList = new List<string>() { "Hello" };

        MyStringIEnumerable = new string[] { "Hello" };
        MyStringIList = new string[] { "Hello" };
        MyStringICollection = new string[] { "Hello" };

        MyStringIEnumerableT = new string[] { "Hello" };
        MyStringIListT = new string[] { "Hello" };
        MyStringICollectionT = new string[] { "Hello" };
        MyStringIReadOnlyCollectionT = new string[] { "Hello" };
        MyStringIReadOnlyListT = new string[] { "Hello" };
        MyStringISetT = new HashSet<string> { "Hello" };

        MyStringToStringKeyValuePair = new KeyValuePair<string, string>("myKey", "myValue");
        MyStringToStringIDict = new Dictionary<string, string> { { "key", "value" } };

        MyStringToStringGenericDict = new Dictionary<string, string> { { "key", "value" } };
        MyStringToStringGenericIDict = new Dictionary<string, string> { { "key", "value" } };
        MyStringToStringGenericIReadOnlyDict = new Dictionary<string, string> { { "key", "value" } };

        MyStringToStringImmutableDict = ImmutableDictionary.CreateRange(MyStringToStringGenericDict);
        MyStringToStringIImmutableDict = ImmutableDictionary.CreateRange(MyStringToStringGenericDict);
        MyStringToStringImmutableSortedDict = ImmutableSortedDictionary.CreateRange(MyStringToStringGenericDict);

        MyStringStackT = new Stack<string>(new List<string>() { "Hello", "World" });
        MyStringQueueT = new Queue<string>(new List<string>() { "Hello", "World" });
        MyStringHashSetT = new HashSet<string>(new List<string>() { "Hello" });
        MyStringLinkedListT = new LinkedList<string>(new List<string>() { "Hello" });
        MyStringSortedSetT = new SortedSet<string>(new List<string>() { "Hello" });

        MyStringIImmutableListT = ImmutableList.CreateRange(new List<string> { "Hello" });
        MyStringIImmutableStackT = ImmutableStack.CreateRange(new List<string> { "Hello" });
        MyStringIImmutableQueueT = ImmutableQueue.CreateRange(new List<string> { "Hello" });
        MyStringIImmutableSetT = ImmutableHashSet.CreateRange(new List<string> { "Hello" });
        MyStringImmutableHashSetT = ImmutableHashSet.CreateRange(new List<string> { "Hello" });
        MyStringImmutableListT = ImmutableList.CreateRange(new List<string> { "Hello" });
        MyStringImmutableStackT = ImmutableStack.CreateRange(new List<string> { "Hello" });
        MyStringImmutablQueueT = ImmutableQueue.CreateRange(new List<string> { "Hello" });
        MyStringImmutableSortedSetT = ImmutableSortedSet.CreateRange(new List<string> { "Hello" });

        MyListOfNullString = new List<string?> { null };
    }
}

[JsonSerializable(typeof(SimpleTestClass))]
[JsonSerializable(typeof(SimpleTestStruct))]
[JsonSerializable(typeof(SimpleStruct))]
[JsonSourceGenerationOptions(JsonSerializerDefaults.Web, WriteIndented = false, DefaultBufferSize = 81920)]
public partial class SimpleTestJsonContext : JsonSerializerContext
{
}
