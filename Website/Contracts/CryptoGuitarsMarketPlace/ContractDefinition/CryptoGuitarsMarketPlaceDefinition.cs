using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace CryptoGuitars.Contracts.CryptoGuitarsMarketPlace.ContractDefinition
{


    public partial class CryptoGuitarsMarketPlaceDeployment : CryptoGuitarsMarketPlaceDeploymentBase
    {
        public CryptoGuitarsMarketPlaceDeployment() : base(BYTECODE) { }
        public CryptoGuitarsMarketPlaceDeployment(string byteCode) : base(byteCode) { }
    }

    public class CryptoGuitarsMarketPlaceDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405266b1a2bc2ec500006004553480156200001c57600080fd5b50604051620011bb380380620011bb8339810160408190526200003f916200018f565b6200004a3362000099565b600180546001600160a01b038086166001600160a01b031992831617909255600280549285169290911691909117905580516200008f906003906020840190620000e9565b50505050620002ff565b600080546001600160a01b038381166001600160a01b0319831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b828054620000f79062000293565b90600052602060002090601f0160209004810192826200011b576000855562000166565b82601f106200013657805160ff191683800117855562000166565b8280016001018555821562000166579182015b828111156200016657825182559160200191906001019062000149565b506200017492915062000178565b5090565b5b8082111562000174576000815560010162000179565b600080600060608486031215620001a4578283fd5b8351620001b181620002e6565b80935050602080850151620001c681620002e6565b60408601519093506001600160401b0380821115620001e3578384fd5b818701915087601f830112620001f7578384fd5b8151818111156200020c576200020c620002d0565b604051601f8201601f19908116603f01168101908382118183101715620002375762000237620002d0565b816040528281528a868487010111156200024f578687fd5b8693505b8284101562000272578484018601518185018701529285019262000253565b828411156200028357868684830101525b8096505050505050509250925092565b600181811c90821680620002a857607f821691505b60208210811415620002ca57634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052604160045260246000fd5b6001600160a01b0381168114620002fc57600080fd5b50565b610eac806200030f6000396000f3fe60806040526004361061007b5760003560e01c8063715018a61161004e578063715018a6146101695780638da5cb5b1461017e5780639f9eadec146101a6578063f2fde38b146101b957600080fd5b80630e518506146100805780632b561fba146100f15780632d296bf1146101345780636492221514610149575b600080fd5b34801561008c57600080fd5b506100a061009b366004610bf9565b6101d9565b6040516100e8919081516001600160a01b0316815260208083015190820152604080830151908201526060808301519082015260809182015115159181019190915260a00190565b60405180910390f35b3480156100fd57600080fd5b5061012461010c366004610bf9565b60009081526006602052604090206004015460ff1690565b60405190151581526020016100e8565b610147610142366004610bf9565b610273565b005b34801561015557600080fd5b50610147610164366004610c29565b6103e5565b34801561017557600080fd5b50610147610678565b34801561018a57600080fd5b506000546040516001600160a01b0390911681526020016100e8565b6101476101b4366004610bba565b6106de565b3480156101c557600080fd5b506101476101d4366004610bba565b61085e565b6102166040518060a0016040528060006001600160a01b031681526020016000815260200160008152602001600081526020016000151581525090565b50600090815260066020908152604091829020825160a08101845281546001600160a01b031681526001820154928101929092526002810154928201929092526003820154606082015260049091015460ff161515608082015290565b600081815260066020526040902060040154819060ff166102ce5760405162461bcd60e51b815260206004820152601060248201526f6f66666572206e6f742061637469766560801b60448201526064015b60405180910390fd5b600082815260066020908152604091829020825160a08101845281546001600160a01b031681526001820154928101839052600282015493810193909352600381015460608401526004015460ff1615156080830152341461036a5760405162461bcd60e51b81526020600482015260156024820152741c185e5b595b9d081b5d5cdd08189948195e1858dd605a1b60448201526064016102c5565b61037381610929565b60015481516040516323b872dd60e01b81526001600160a01b039182166004820152336024820152604481018690529116906323b872dd90606401600060405180830381600087803b1580156103c857600080fd5b505af11580156103dc573d6000803e3d6000fd5b50505050505050565b6001546040516331a9108f60e11b81526004810184905283916001600160a01b031690636352211e9060240160206040518083038186803b15801561042957600080fd5b505afa15801561043d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906104619190610bdd565b6001600160a01b0316336001600160a01b0316146104b35760405162461bcd60e51b815260206004820152600f60248201526e3737ba103a37b5b2b71037bbb732b960891b60448201526064016102c5565b600083815260066020526040902060040154839060ff16156105095760405162461bcd60e51b815260206004820152600f60248201526e323ab83634b1b0ba329037b33332b960891b60448201526064016102c5565b50506040805160a08101825233815260208082019384526005805483850181815260608501888152600160808701818152818501865560008681528851959096027f036b6384b5eca791c62761152d0c79bb0604c104a5fb6f4eb0703f3154bb3db0810180546001600160a01b039788166001600160a01b0319918216179091558b517f036b6384b5eca791c62761152d0c79bb0604c104a5fb6f4eb0703f3154bb3db183015585517f036b6384b5eca791c62761152d0c79bb0604c104a5fb6f4eb0703f3154bb3db283015584517f036b6384b5eca791c62761152d0c79bb0604c104a5fb6f4eb0703f3154bb3db383015582517f036b6384b5eca791c62761152d0c79bb0604c104a5fb6f4eb0703f3154bb3db4909201805492151560ff199384161790559b875260069097529790942095518654931692909816919091178455945190830155925160028201559251600384015551600492909201805492151592909116919091179055565b6000546001600160a01b031633146106d25760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016102c5565b6106dc6000610981565b565b600454341461072f5760405162461bcd60e51b815260206004820152601860248201527f65746865722076616c756520697320696e636f7272656374000000000000000060448201526064016102c5565b600154604080516318160ddd60e01b815290516000926001600160a01b0316916318160ddd916004808301926020929190829003018186803b15801561077457600080fd5b505afa158015610788573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906107ac9190610c11565b905060006107b9826109d1565b600154604051636902622f60e11b81529192506001600160a01b03169063d204c45e906107ec9086908590600401610d55565b600060405180830381600087803b15801561080657600080fd5b505af115801561081a573d6000803e3d6000fd5b50506002546040516001600160a01b0390911692503480156108fc029250906000818181858888f19350505050158015610858573d6000803e3d6000fd5b50505050565b6000546001600160a01b031633146108b85760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016102c5565b6001600160a01b03811661091d5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016102c5565b61092681610981565b50565b6109368160600151610a05565b60208101511561092657805160208201516040516001600160a01b039092169181156108fc0291906000818181858888f1935050505015801561097d573d6000803e3d6000fd5b5050565b600080546001600160a01b038381166001600160a01b0319831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b606060036109de83610a98565b6040516020016109ef929190610c66565b6040516020818303038152906040529050919050565b600081815260066020526040812060020154600580549091908110610a3a57634e487b7160e01b600052603260045260246000fd5b6000918252602080832060046005909302018201805494151560ff1995861617905593825260069093526040812080546001600160a01b03191681556001810182905560028101829055600381019190915590910180549091169055565b606081610abc5750506040805180820190915260018152600360fc1b602082015290565b8160005b8115610ae65780610ad081610e06565b9150610adf9050600a83610daf565b9150610ac0565b60008167ffffffffffffffff811115610b0f57634e487b7160e01b600052604160045260246000fd5b6040519080825280601f01601f191660200182016040528015610b39576020820181803683370190505b5090505b8415610bb257610b4e600183610dc3565b9150610b5b600a86610e21565b610b66906030610d97565b60f81b818381518110610b8957634e487b7160e01b600052603260045260246000fd5b60200101906001600160f81b031916908160001a905350610bab600a86610daf565b9450610b3d565b949350505050565b600060208284031215610bcb578081fd5b8135610bd681610e61565b9392505050565b600060208284031215610bee578081fd5b8151610bd681610e61565b600060208284031215610c0a578081fd5b5035919050565b600060208284031215610c22578081fd5b5051919050565b60008060408385031215610c3b578081fd5b50508035926020909101359150565b60008151610c5c818560208601610dda565b9290920192915050565b600080845482600182811c915080831680610c8257607f831692505b6020808410821415610ca257634e487b7160e01b87526022600452602487fd5b818015610cb65760018114610cc757610cf3565b60ff19861689528489019650610cf3565b60008b815260209020885b86811015610ceb5781548b820152908501908301610cd2565b505084890196505b505050505050610d4c610d32610d2c837f2f6d657461646174612f43727970746f477569746172732d0000000000000000815260180190565b86610c4a565b6d16b6b2ba30b230ba30973539b7b760911b8152600e0190565b95945050505050565b60018060a01b03831681526040602082015260008251806040840152610d82816060850160208701610dda565b601f01601f1916919091016060019392505050565b60008219821115610daa57610daa610e35565b500190565b600082610dbe57610dbe610e4b565b500490565b600082821015610dd557610dd5610e35565b500390565b60005b83811015610df5578181015183820152602001610ddd565b838111156108585750506000910152565b6000600019821415610e1a57610e1a610e35565b5060010190565b600082610e3057610e30610e4b565b500690565b634e487b7160e01b600052601160045260246000fd5b634e487b7160e01b600052601260045260246000fd5b6001600160a01b038116811461092657600080fdfea26469706673582212203149953507273a077039fd7de95366b0cabdee40739a1ed27894a37d8211de2c64736f6c63430008040033";
        public CryptoGuitarsMarketPlaceDeploymentBase() : base(BYTECODE) { }
        public CryptoGuitarsMarketPlaceDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "cryptoGuitarsNFTContractAddress", 1)]
        public virtual string CryptoGuitarsNFTContractAddress { get; set; }
        [Parameter("address", "feeReceiverAddress", 2)]
        public virtual string FeeReceiverAddress { get; set; }
        [Parameter("string", "uriBaseAddress", 3)]
        public virtual string UriBaseAddress { get; set; }
    }

    public partial class BuyTokenFunction : BuyTokenFunctionBase { }

    [Function("buyToken")]
    public class BuyTokenFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class CreateNewTokenFunction : CreateNewTokenFunctionBase { }

    [Function("createNewToken")]
    public class CreateNewTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
    }

    public partial class GetActiveOfferFunction : GetActiveOfferFunctionBase { }

    [Function("getActiveOffer", typeof(GetActiveOfferOutputDTO))]
    public class GetActiveOfferFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class HasActiveOfferFunction : HasActiveOfferFunctionBase { }

    [Function("hasActiveOffer", "bool")]
    public class HasActiveOfferFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class OfferTokenFunction : OfferTokenFunctionBase { }

    [Function("offerToken")]
    public class OfferTokenFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "price", 2)]
        public virtual BigInteger Price { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }





    public partial class GetActiveOfferOutputDTO : GetActiveOfferOutputDTOBase { }

    [FunctionOutput]
    public class GetActiveOfferOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual Offer ReturnValue1 { get; set; }
    }

    public partial class HasActiveOfferOutputDTO : HasActiveOfferOutputDTOBase { }

    [FunctionOutput]
    public class HasActiveOfferOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }



    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }




}