namespace XPT.Legacy.Maps {
    public enum MapEventType {
        /// <summary>
        /// Encounter event. Show messages.
        /// </summary>
        Encounter,
        /// <summary>
        /// Faces a wall. Show messages.
        /// </summary>
        FaceLook,
        /// <summary>
        /// Steps into a wall. Do not show messages.
        /// </summary>
        FaceStep,
        /// <summary>
        /// Arrives in the tile. Show messages.
        /// </summary>
        TileArrive,
        /// <summary>
        /// Use of an item. Accompanied by item index. Show messages if item is referenced.
        /// </summary>
        UseItem,
        /// <summary>
        /// Use of a skill or spell. Accompanied by spell index. Show messages if skill is referenced.
        /// </summary>
        UseSkillSpell
    }
}
