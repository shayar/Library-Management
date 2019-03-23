﻿using LibraryData.Models;
using System;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<Checkouts> GetAll();
        Checkouts Get(int id);
        void Add(Checkouts newCheckout);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        void PlaceHold(int assetId, int libraryCardId);
        void CheckoutItem(int id, int libraryCardId);
        void CheckInItem(int id);
        Checkouts GetLatestCheckout(int id);
        int GetNumberOfCopies(int id);
        bool IsCheckedOut(int id);

        string GetCurrentHoldPatron(int id);
        DateTime GetCurrentHoldPlaced(int id);
        string GetCurrentPatron(int id);
        IEnumerable<Holds> GetCurrentHolds(int id);

        void MarkLost(int id);
        void MarkFound(int id);
    }
}
