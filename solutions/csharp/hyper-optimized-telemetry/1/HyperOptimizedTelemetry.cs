public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)=> (reading switch{
                <int.MinValue or >uint.MaxValue => new byte[]{256-sizeof(long)}.Concat(BitConverter.GetBytes((long)reading)),
                <short.MinValue or >ushort.MaxValue and <=int.MaxValue => new byte[]{256-sizeof(int)}.Concat(BitConverter.GetBytes((int)reading)).Concat(new byte[4]),
                <ushort.MinValue => new byte[]{256-sizeof(short)}.Concat(BitConverter.GetBytes((short)reading)).Concat(new byte[6]),
                <=ushort.MaxValue => new byte[]{sizeof(ushort)}.Concat(BitConverter.GetBytes((ushort)reading)).Concat(new byte[6]),
                <=uint.MaxValue => new byte[]{sizeof(uint)}.Concat(BitConverter.GetBytes((uint)reading)).Concat(new byte[4])  }).ToArray();

    public static long FromBuffer(byte[] buffer)=> (buffer[0] switch{
        256-sizeof(long) => BitConverter.ToInt64(buffer,1),
        256-sizeof(int) => BitConverter.ToInt32(buffer,1),
        256-sizeof(short) => BitConverter.ToInt16(buffer,1),
        sizeof(ushort) => BitConverter.ToUInt16(buffer,1),
        sizeof(uint) => BitConverter.ToUInt32(buffer,1),
        _=> 0
    });
}

