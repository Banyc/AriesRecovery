namespace AriesRecovery.Core.Models
{
    public record LogRow
    {
        /// <summary>
        /// log sequence number
        /// </summary>
        public int Lsn { get; set; }
        public int TransId { get; set; }
        public int PrevLsn { get; set; }
        public int RedoInfo { get; set; }
        public int UndoInfo { get; set; }
    }
}
