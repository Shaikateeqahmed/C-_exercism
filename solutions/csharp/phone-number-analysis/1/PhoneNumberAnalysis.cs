public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
       var splitPhoneNumber = phoneNumber.Split('-').ToArray();
       var condition1 = splitPhoneNumber[0] == "212";
       var condition2 = splitPhoneNumber[1] == "555";
        return (splitPhoneNumber[0] == "212", splitPhoneNumber[1] == "555", splitPhoneNumber[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsNewYork && phoneNumberInfo.IsFake && phoneNumberInfo.LocalNumber == "1234";
    }
}
