﻿using System;
using System.Collections.Generic;

namespace Decima.HZD
{
    [RTTI.Serializable(0xE6A4D10BC69EFF20, GameType.HZD)]
    public class CountdownTimerManager : RTTIObject, RTTI.ISaveSerializable
    {
        public List<(BaseGGUUID, CountdownTimerSave)> TimerObjects;

        public void DeserializeStateObject(SaveState state)
        {
            state.DeserializeObjectClassMembers(typeof(CountdownTimerManager), this);

            TimerObjects = state.ReadVariableItemList((ref (BaseGGUUID GUID, CountdownTimerSave) e) =>
            {
                e.GUID = state.ReadIndexedGUID();
                e.Item2 = state.ReadObjectHandle() as CountdownTimerSave;
            });
        }
        public void SerializeStateObject(SaveState state) => throw new NotImplementedException();
    }
}