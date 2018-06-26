#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap32 : AMapScripted {
        protected override int MapIndex => 32;
        
        public YserMap32() {
            MapEvent01 = FnVOID_01;
            MapEvent02 = FnISLEETRN_02;
            MapEvent03 = FnENCSELF_03;
            MapEvent04 = FnENCWINTR_04;
            MapEvent05 = FnRAINRED_05;
            MapEvent06 = FnRAINYEL_06;
            MapEvent07 = FnRAINGRN_07;
            MapEvent08 = FnRAINBLU_08;
            MapEvent09 = FnENCTIME_09;
            MapEvent0A = FnTELENW_0A;
            MapEvent0B = FnTELENE_0B;
            MapEvent0C = FnTELESE_0C;
            MapEvent0D = FnTELESW_0D;
        }
        
        // === Strings ================================================
        private const string String03FC = "The Ageless Void swallows you whole.";
        private const string String0421 = "Time freezes forever in your mind.  To the rest of the world, you are dead.";
        private const string String046D = "The Island of Eternity sits at the edge of time.";
        private const string String049E = "Along its edge is the Ageless Void, a vastness where time does not exist.";
        private const string String04E8 = "A titanic Elemental appears!";
        private const string String0505 = "'You have gotten past Zephyr, Tempest, ZZyzx, Heaven's Fury, and all other winds.  But now you face your greatest challenge!'";
        private const string String0583 = "The sky above you darkens and dark clouds mass together. Tornadoes swirl around you.  Hurricane winds beat against you.  The clouds shine with the endless flash of lightning.";
        private const string String0632 = "The winds rip at your weapons.";
        private const string String0651 = "Your weapon snaps in the wind!  It is gone.";
        private const string String067D = "The Wind Sword resists the winds!  It will indeed be a good fight!";
        private const string String06C0 = "You notice En-Li-Kil, the Time Elemental, vanish.";
        private const string String06F2 = "A streak of Red crosses the Ageless Void.";
        private const string String071C = "A streak of Yellow crosses the Ageless Void.";
        private const string String0749 = "A streak of Green crosses the Ageless Void.";
        private const string String0775 = "A streak of Blue crosses the Ageless Void.";
        private const string String07A0 = "Threads of blinding light appear from all directions, bending and weaving into a tight spiral before you.";
        private const string String080A = "From within the luminary vortex, an ageless elemental appears.";
        private const string String0849 = "'I am Time, I am En-Li-Kil.  I have seen the birth of the universe and I will mark its death.'";
        private const string String08A8 = "His face turns with age, then glows bright red.";
        private const string String08D8 = "'Arnakkian summoned me to this realm -- to watch over his soul -- to make him immortal.  He lost his body and his castle for his lust.";
        private const string String095F = "Mortal!  You have no business in the affairs of Time. I waste myself no more, my Wind Elemental will deal with you.'";
        private const string String09D4 = "You enter another dimension.";
        private const string String09F1 = "You enter another dimension.";
        private const string String0A0E = "You enter another dimension.";
        private const string String0A2B = "You enter another dimension.";
        
        // === Functions ================================================
        private void FnVOID_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // The Ageless Void swallows you whole.
            L0010: ShowMessage(party, String0421); // Time freezes forever in your mind.  To the rest of the world, you are dead.
            L001D: ax = GetMaxHits(party);
            L0024: DamagePlayer(party, ax);
            L002E: return; // RETURN;
        }

        private void FnISLEETRN_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String046D); // The Island of Eternity sits at the edge of time.
            L0010: ShowMessage(party, String049E); // Along its edge is the Ageless Void, a vastness where time does not exist.
            L001D: return; // RETURN;
        }

        private void FnENCSELF_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x19);
            L0015: AddEncounter(party, 0x02, 0x19);
            L0027: AddEncounter(party, 0x03, 0x19);
            L0039: AddEncounter(party, 0x04, 0x19);
            L004B: AddEncounter(party, 0x05, 0x1A);
            L005D: AddEncounter(party, 0x06, 0x1A);
            L006F: return; // RETURN;
        }

        private void FnENCWINTR_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04E8); // A titanic Elemental appears!
            L0010: ShowMessage(party, String0505); // 'You have gotten past Zephyr, Tempest, ZZyzx, Heaven's Fury, and all other winds.  But now you face your greatest challenge!'
            L001D: ShowMessage(party, String0583); // The sky above you darkens and dark clouds mass together. Tornadoes swirl around you.  Hurricane winds beat against you.  The clouds shine with the endless flash of lightning.
            L002A: ShowMessage(party, String0632); // The winds rip at your weapons.
            L0037: ax = GetEquippedWeapon(party);
            L003F: Compare(ax, 0x0009);
            L0042: if (JumpEqual) goto L0064;
            L0044: ShowMessage(party, String0651); // Your weapon snaps in the wind!  It is gone.
            L0051: ax = GetEquippedWeapon(party);
            L0059: RemoveItem(party, ax);
            L0062: goto L0071;
            L0064: ShowMessage(party, String067D); // The Wind Sword resists the winds!  It will indeed be a good fight!
            L0071: ShowMessage(party, String06C0); // You notice En-Li-Kil, the Time Elemental, vanish.
            L007E: AddEncounter(party, 0x01, 0x19);
            L0090: AddEncounter(party, 0x02, 0x19);
            L00A2: AddEncounter(party, 0x03, 0x19);
            L00B4: AddEncounter(party, 0x04, 0x19);
            L00C6: AddEncounter(party, 0x06, 0x1B);
            L00D8: return; // RETURN;
        }

        private void FnRAINRED_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06F2); // A streak of Red crosses the Ageless Void.
            L0010: TeleportParty(party, 0x38, 0x03, 0x97, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnRAINYEL_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String071C); // A streak of Yellow crosses the Ageless Void.
            L0010: TeleportParty(party, 0x38, 0x03, 0x87, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnRAINGRN_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0749); // A streak of Green crosses the Ageless Void.
            L0010: TeleportParty(party, 0x38, 0x03, 0x77, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnRAINBLU_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0775); // A streak of Blue crosses the Ageless Void.
            L0010: TeleportParty(party, 0x38, 0x03, 0x67, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnENCTIME_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07A0); // Threads of blinding light appear from all directions, bending and weaving into a tight spiral before you.
            L0010: ShowMessage(party, String080A); // From within the luminary vortex, an ageless elemental appears.
            L001D: ShowMessage(party, String0849); // 'I am Time, I am En-Li-Kil.  I have seen the birth of the universe and I will mark its death.'
            L002A: ShowMessage(party, String08A8); // His face turns with age, then glows bright red.
            L0037: ShowMessage(party, String08D8); // 'Arnakkian summoned me to this realm -- to watch over his soul -- to make him immortal.  He lost his body and his castle for his lust.
            L0044: ShowMessage(party, String095F); // Mortal!  You have no business in the affairs of Time. I waste myself no more, my Wind Elemental will deal with you.'
            L0051: return; // RETURN;
        }

        private void FnTELENW_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09D4); // You enter another dimension.
            L0010: TeleportParty(party, 0x39, 0x01, 0x54, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELENE_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09F1); // You enter another dimension.
            L0010: TeleportParty(party, 0x39, 0x01, 0x4A, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTELESE_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A0E); // You enter another dimension.
            L0010: TeleportParty(party, 0x39, 0x01, 0xAB, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELESW_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A2B); // You enter another dimension.
            L0010: TeleportParty(party, 0x39, 0x01, 0xB5, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

    }
}
