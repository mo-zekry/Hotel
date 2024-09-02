namespace Hotel.Server.Models.Statues;

public enum RoomStatus
{
    Available,
    Occupied,
    Maintenance,
    Cleaning
}

public enum BookingStatus
{
    Pending,
    Confirmed,
    CheckedIn,
    CheckedOut,
    Cancelled
}

public enum PaymentMethod
{
    CreditCard,
    DebitCard,
    Cash,
    BankTransfer,
    OnlinePayment
}

public enum PaymentStatus
{
    Pending,
    Completed,
    Failed,
    Refunded
}

public enum TaskStatus
{
    Pending,
    InProgress,
    Completed
}

public enum RequestStatus
{
    Open,
    InProgress,
    Completed,
    Cancelled
}
