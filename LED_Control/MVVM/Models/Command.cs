using System.Collections.ObjectModel;

namespace LED_Control.MVVM.Models;

internal class Command
{
    public byte CommandId { get; set; }

    public byte Address { get; set; }

    public int BufferId { get; set; }

    public string? Value { get; set; }
}

internal static class CommandList
{
    public static ObservableCollection<Command> GetCommands() => new()
    {
        new Command() { CommandId = 100, Address = 0, BufferId = 5, Value = "[00] Set default" },
        new Command() { CommandId = 101, Address = 1, BufferId = 5, Value = "[01] Set Add-boards LED 01" },
        new Command() { CommandId = 101, Address = 2, BufferId = 6, Value = "[02] Set Add-boards LED 02" },
        new Command() { CommandId = 101, Address = 3, BufferId = 7, Value = "[03] Set Add-boards LED 03" },
        new Command() { CommandId = 101, Address = 4, BufferId = 8, Value = "[04] Set Add-boards LED 04" },
        new Command() { CommandId = 102, Address = 5, BufferId = 5, Value = "[05] Set On-board LED 01" },
        new Command() { CommandId = 102, Address = 6, BufferId = 6, Value = "[06] Set On-board LED 02" },
        new Command() { CommandId = 102, Address = 7, BufferId = 7, Value = "[07] Set On-board LED 03" },
        new Command() { CommandId = 102, Address = 8, BufferId = 8, Value = "[08] Set On-board LED 04" },
        new Command() { CommandId = 102, Address = 9, BufferId = 9, Value = "[09] Set On-board LED 05" },
        new Command() { CommandId = 102, Address = 10, BufferId = 10, Value = "[10] Set On-board LED 06" },
        new Command() { CommandId = 102, Address = 11, BufferId = 11, Value = "[11] Set On-board LED 07" },
        new Command() { CommandId = 102, Address = 12, BufferId = 12, Value = "[12] Set On-board LED 08" },
        new Command() { CommandId = 102, Address = 13, BufferId = 13, Value = "[13] Set On-board LED 09" },
        new Command() { CommandId = 102, Address = 14, BufferId = 14, Value = "[14] Set On-board LED 10" },
        new Command() { CommandId = 102, Address = 15, BufferId = 15, Value = "[15] Set On-board LED 11" },
        new Command() { CommandId = 102, Address = 16, BufferId = 16, Value = "[16] Set On-board LED 12" },
        new Command() { CommandId = 102, Address = 17, BufferId = 17, Value = "[17] Set On-board LED 13" },
        new Command() { CommandId = 102, Address = 18, BufferId = 18, Value = "[18] Set On-board LED 14" },
        new Command() { CommandId = 102, Address = 19, BufferId = 19, Value = "[19] Set On-board LED 15" },
        new Command() { CommandId = 102, Address = 20, BufferId = 20, Value = "[20] Set On-board LED 16" },
        new Command() { CommandId = 102, Address = 21, BufferId = 21, Value = "[21] Set On-board LED 17" },
        new Command() { CommandId = 102, Address = 22, BufferId = 22, Value = "[22] Set On-board LED 18" },
        new Command() { CommandId = 102, Address = 23, BufferId = 23, Value = "[23] Set On-board LED 19" },
        new Command() { CommandId = 102, Address = 24, BufferId = 24, Value = "[24] Set On-board LED 20" },
        new Command() { CommandId = 103, Address = 25, BufferId = 5, Value = "[25] Set Slave-board LED 01" },
        new Command() { CommandId = 103, Address = 26, BufferId = 6, Value = "[26] Set Slave-board LED 02" },
        new Command() { CommandId = 103, Address = 27, BufferId = 7, Value = "[27] Set Slave-board LED 03" },
        new Command() { CommandId = 103, Address = 28, BufferId = 8, Value = "[28] Set Slave-board LED 04" },
        new Command() { CommandId = 103, Address = 29, BufferId = 9, Value = "[29] Set Slave-board LED 05" },
        new Command() { CommandId = 103, Address = 30, BufferId = 10, Value = "[30] Set Slave-board LED 06" },
        new Command() { CommandId = 103, Address = 31, BufferId = 11, Value = "[31] Set Slave-board LED 07" },
        new Command() { CommandId = 103, Address = 32, BufferId = 12, Value = "[32] Set Slave-board LED 08" },
        new Command() { CommandId = 103, Address = 33, BufferId = 13, Value = "[33] Set Slave-board LED 09" },
        new Command() { CommandId = 103, Address = 34, BufferId = 14, Value = "[34] Set Slave-board LED 10" },
        new Command() { CommandId = 103, Address = 35, BufferId = 15, Value = "[35] Set Slave-board LED 11" },
        new Command() { CommandId = 103, Address = 36, BufferId = 16, Value = "[36] Set Slave-board LED 12" },
        new Command() { CommandId = 103, Address = 37, BufferId = 17, Value = "[37] Set Slave-board LED 13" },
        new Command() { CommandId = 103, Address = 38, BufferId = 18, Value = "[38] Set Slave-board LED 14" },
        new Command() { CommandId = 103, Address = 39, BufferId = 19, Value = "[39] Set Slave-board LED 15" },
        new Command() { CommandId = 103, Address = 40, BufferId = 20, Value = "[40] Set Slave-board LED 16" },
        new Command() { CommandId = 103, Address = 41, BufferId = 21, Value = "[41] Set Slave-board LED 17" },
        new Command() { CommandId = 103, Address = 42, BufferId = 22, Value = "[42] Set Slave-board LED 18" },
        new Command() { CommandId = 103, Address = 43, BufferId = 23, Value = "[43] Set Slave-board LED 19" },
        new Command() { CommandId = 103, Address = 44, BufferId = 24, Value = "[44] Set Slave-board LED 20" },
        new Command() { CommandId = 103, Address = 45, BufferId = 5, Value = "[45] Set Extra LED 01" },
        new Command() { CommandId = 103, Address = 46, BufferId = 6, Value = "[46] Set Extra LED 02" },
        new Command() { CommandId = 103, Address = 47, BufferId = 7, Value = "[47] Set Extra LED 03" },
        new Command() { CommandId = 103, Address = 48, BufferId = 8, Value = "[48] Set Extra LED 04" },
        new Command() { CommandId = 103, Address = 49, BufferId = 9, Value = "[49] Set Extra LED 05" },
        new Command() { CommandId = 103, Address = 50, BufferId = 10, Value = "[50] Set Extra LED 06" },
        new Command() { CommandId = 103, Address = 51, BufferId = 11, Value = "[51] Set Extra LED 07" },
        new Command() { CommandId = 103, Address = 52, BufferId = 12, Value = "[52] Set Extra LED 08" },
        new Command() { CommandId = 103, Address = 53, BufferId = 13, Value = "[53] Set Extra LED 09" },
        new Command() { CommandId = 103, Address = 54, BufferId = 14, Value = "[54] Set Extra LED 10" },
    };
}
