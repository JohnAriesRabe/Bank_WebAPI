using Bank_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BCrypt.Net;

namespace Bank_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly BankDBContext _context;

        public BankController(BankDBContext context)
        {
            _context = context;
        }

        [HttpPost("add-user")]
        public IActionResult AddUser(UserInfo user)
        {
            // Hash the password using BCrypt.Net-Next
            //user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password);

            var Searchuser = _context._User.FirstOrDefault(u => u.userID == user.UserID);
            if (Searchuser == null)
            {
                User _user = new User();
                _user.fullName = user.FullName;
                _user.mobile = user.Mobile;
                _user.userID = user.UserID;
                _user.Balance = user.Balance;
                _user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password);
                _context._User.Add(_user);
                _context.SaveChanges();
                return Ok("User added successfully.");
            }
            else
                return BadRequest("Invalid UserID.");
        }

        [HttpGet("balance/{userId}")]
        public IActionResult GetBalance(string userId)
        {
            var user = _context._User.FirstOrDefault(u => u.userID == userId);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            return Ok($"Balance for User {user.userID}: {user.Balance}");
        }

        [HttpPost("withdraw")]
        public IActionResult Withdraw(WithdrawRequest request)
        {
            var user = _context._User.FirstOrDefault(u => u.userID == request.userID);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            if (user.Balance < request.Amount)
            {
                return BadRequest("Insufficient balance.");
            }

            user.Balance -= request.Amount;
            _context._WithdrawRequest.Add(request);
            _context.SaveChanges();
            return Ok("Withdrawal successful.");
        }

        [HttpPost("deposit")]
        public IActionResult Deposit(DepositRequest request)
        {
            var user = _context._User.FirstOrDefault(u => u.userID == request.userID);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            user.Balance += request.Amount;
            _context._DepositRequest.Add(request);
            _context.SaveChanges();
            return Ok("Deposit successful.");
        }

        [HttpPost("transfer")]
        public IActionResult Transfer(TransferRequest request)
        {
            var sender =  _context._User.FirstOrDefault(u => u.userID == request.SenderUserId);
            var receiver =  _context._User.FirstOrDefault(u => u.userID == request.ReceiverUserId);

            if (sender == null || receiver == null)
            {
                return NotFound("User(s) not found.");
            }

            if (sender.Balance < request.Amount)
            {
                return BadRequest("Insufficient balance.");
            }

            sender.Balance -= request.Amount;
            receiver.Balance += request.Amount;

            _context._TransferRequest.Add(request);
            _context.SaveChanges();
            return Ok("Transfer successful.");
        }
    }
}
