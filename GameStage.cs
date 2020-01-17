namespace Rock_Paper_Scissors
{
    /// <summary>
    /// Represents current game stage.
    /// </summary>
    enum GameStage
    {
        /// <summary>
        /// Game has this stage after startup.
        /// </summary>
        BeforeStart,
        /// <summary>
        /// Game has this stage when human has to move.
        /// </summary>
        HumanMove,
        /// <summary>
        /// Game has this stage when computer has to move.
        /// </summary>
        ComputerMove,
        /// <summary>
        /// Game has this stage when it finished.
        /// </summary>
        Finished
    }
}