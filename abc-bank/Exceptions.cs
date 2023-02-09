﻿using System;

namespace abc_bank {

  [Serializable]
  public class InvalidTransactionAmountException : Exception {
    public override string Message => "amount must be greater than zero";
  }

  [Serializable]
  public class InsufficientFundsException : Exception {
    public override string Message => "Insufficient funds to complete this transaction.";
  }
}
