using System;
using System.Collections.Generic;

namespace HotelReservations
{
    public class Reservation
    {
        public Dictionary<int, int> Capacity { get; set; }

        public Reservation(int size)
        {
            if (size > 1000 || size < 1)
                throw new ArgumentOutOfRangeException("0 < size <= 1000 !");

            Capacity = new Dictionary<int, int>();

            for (int i = 0; i < 365; i++)
                Capacity.Add(i, size);
        }

        public string MakeReservation(int startDay, int endDay)
        {
            if (startDay < 0 || endDay >= 365)
                return "Decline";

            if (IsAvaliable(startDay, endDay))
            {
                UpdateCapacity(startDay, endDay);
                return "Accept";
            }

            return "Decline";
        }

        private bool IsAvaliable(int startDay, int endDay)
        {
            for (int i = startDay; i <= endDay; i++)
                if (Capacity[i] < 1)
                    return false;

            return true;
        }

        private void UpdateCapacity(int startDay, int endDay)
        {
            for (int i = startDay; i <= endDay; i++)
                Capacity[i]--;
        }
    }
}
