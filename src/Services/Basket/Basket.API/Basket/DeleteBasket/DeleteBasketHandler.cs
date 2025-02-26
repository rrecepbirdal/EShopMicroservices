
namespace Basket.API.Basket.DeleteBasket
{
    public record DeleteBasketCommmand(string UserName) : ICommand<DeleteBasketResult>;
    public record DeleteBasketResult(bool IsSuccess);

    public class DeleteBasketCommandValidator : AbstractValidator<DeleteBasketCommmand>
    {
        public DeleteBasketCommandValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");
        }
    }
    public class DeleteBasketCommandHandler(IBasketRepository repository)
        : ICommandHandler<DeleteBasketCommmand, DeleteBasketResult>
    {
        public async Task<DeleteBasketResult> Handle(DeleteBasketCommmand command, CancellationToken cancellationToken)
        {
            await repository.DeleteBasket(command.UserName,cancellationToken);
            return new DeleteBasketResult(true);
        }
    }
}
