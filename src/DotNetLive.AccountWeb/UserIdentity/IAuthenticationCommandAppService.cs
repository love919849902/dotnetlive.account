﻿using AutoMapper;
using DotNetLive.AccountWeb.Data.Repositories;
using DotNetLive.AccountWeb.Entities;

namespace DotNetLive.AccountWeb.UserIdentity
{
    public interface IAuthenticationCommandAppService
    {
        void Create(Account account);
        void Update(Account account);
    }

    public class AuthenticationCommandAppService : IAuthenticationCommandAppService
    {
        private IMapper _mapper;
        private ICommandRepository _commandRepository;
        private IQueryRepository _queryRepository;

        public AuthenticationCommandAppService(ICommandRepository commandRepository,
            IQueryRepository queryRepository,
            IMapper mapper)
        {
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
            _mapper = mapper;
        }

        public void Create(Account account)
        {
            _commandRepository.Add(account);
        }

        public void Update(Account account)
        {
            _commandRepository.Update(account);
        }
    }
}