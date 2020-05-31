using HotelReservations;
using System;
using Xunit;

namespace ReservationsTest
{
    public class ReservationsTest
    {
        [Theory]
        [InlineData(-4, 2, "Decline")]
        [InlineData(200, 400, "Decline")]
        public void TestCase_1a_1b( int startDay, int endDay, string expected)
        {
            Reservation reservation = new Reservation(1);

            string result = reservation.MakeReservation(startDay, endDay);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[6] { 0, 7, 3, 5, 6, 0},
                    new int[6] { 5, 13, 9, 7, 6, 4},
                    new string[6] { "Accept", "Accept", "Accept", "Accept", "Accept", "Accept" })]
        public void TestCase_2(int[] startDays, int[] endDays, string[] expectedResults)
        {
            Reservation reservation = new Reservation(3);

            for (int i = 0; i < startDays.Length; i++)
            {
                string result = reservation.MakeReservation(startDays[i], endDays[i]);

                Assert.Equal(expectedResults[i], result);
            }
        }

        [Theory]
        [InlineData(new int[4] { 1, 2, 1, 0 },
                    new int[4] { 2, 5, 9, 15 },
                    new string[4] { "Accept", "Accept", "Accept", "Decline" })]
        public void TestCase_3(int[] startDays, int[] endDays, string[] expectedResults)
        {
            Reservation reservation = new Reservation(3);

            for (int i = 0; i < startDays.Length; i++)
            {
                string result = reservation.MakeReservation(startDays[i], endDays[i]);

                Assert.Equal(expectedResults[i], result);
            }
        }

        [Theory]
        [InlineData(new int[5] { 1, 0, 1, 2, 4 },
                    new int[5] { 3, 15, 9, 5, 9 },
                    new string[5] { "Accept", "Accept", "Accept", "Decline", "Accept" })]
        public void TestCase_4(int[] startDays, int[] endDays, string[] expectedResults)
        {
            Reservation reservation = new Reservation(3);

            for (int i = 0; i < startDays.Length; i++)
            {
                string result = reservation.MakeReservation(startDays[i], endDays[i]);

                Assert.Equal(expectedResults[i], result);
            }
        }

        [Theory]
        [InlineData(new int[9] { 1, 0, 2, 5, 4, 10, 6, 8, 8 },
                    new int[9] { 3, 4, 3, 5, 10, 10, 7, 10, 9 },
                    new string[9] { "Accept", "Accept", "Decline", "Accept", "Accept", 
                                    "Accept", "Accept", "Decline", "Accept" })]
        public void TestCase_5(int[] startDays, int[] endDays, string[] expectedResults)
        {
            Reservation reservation = new Reservation(2);

            for (int i = 0; i < startDays.Length; i++)
            {
                string result = reservation.MakeReservation(startDays[i], endDays[i]);

                Assert.Equal(expectedResults[i], result);
            }
        }
    }
}
