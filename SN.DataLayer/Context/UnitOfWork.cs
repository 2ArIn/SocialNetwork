using SN.DataLayer.Repositories;
using SN.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        SocialNetDBEntities db = new SocialNetDBEntities();
        private IUserRepository _userRepository;

        private IPostRepository _postRepository;

        private GenericRepositiry<MyUser> _userGRepository;

        //private IFollowRepository _followerRepository;
        //private GenericRepositiry<MyFollow> _followerGRepository;

        //private IFollowRepository _followingRepository;
        //private GenericRepositiry<MyFollow> _followingGRepository;

        private IFollowRepository _followRepository;
        private GenericRepositiry<MyFollow> _followGRepository;


        private GenericRepositiry<MyLike> _likeGRepository;
        private LikeRepository _likeRepository;
        
        private MessageRepository _messageRepository;
        private GenericRepositiry<Message> _messageGRepository;

        public MessageRepository MessageRepository
        {
            get
            {
                if(_messageRepository == null)
                {
                    _messageRepository = new MessageRepository(db);
                }
                return _messageRepository;
            }
        }
        public GenericRepositiry<Message> MessageGRepository
        {
            get
            {
                if(_messageGRepository == null)
                {
                    _messageGRepository = new GenericRepositiry<Message>(db);
                }
                return _messageGRepository;
            }
        }

        public LikeRepository LikeRepository
        {
            get
            {
                if(_likeRepository == null)
                {
                    _likeRepository = new LikeRepository(db);
                }
                return _likeRepository;
            }
        }
        public GenericRepositiry<MyLike> LikeGRepository
        {
            get
            {
                if(_likeGRepository ==null)
                {
                    _likeGRepository = new GenericRepositiry<MyLike>(db);
                }
                return _likeGRepository;
            }
        }

        public GenericRepositiry<MyUser> UserGRepository
        {
            get
            {
                if(_userGRepository == null)
                {
                    _userGRepository = new GenericRepositiry<MyUser>(db);
                }
                return _userGRepository;
            }
        }
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(db);
                }

                return _userRepository;
            }
        }
        

        public IPostRepository PostRepository {

            get 
            { 
                if(_postRepository == null)
                {
                    _postRepository = new PostRepository(db);
                }
                return _postRepository;
            }
            
        }
        public GenericRepositiry<MyFollow> FollowGRepository
        {
            get
            {
                if (_followGRepository == null)
                {
                    _followGRepository = new GenericRepositiry<MyFollow>(db);
                }
                return _followGRepository;
            }
        }
        public IFollowRepository FollowRepository
        {
            get
            {
                if (_followRepository == null)
                {
                    _followRepository = new FollowRepository(db);
                }

                return _followRepository;
            }
        }
        //public GenericRepositiry<MyFollow> FollowerGRepository
        //{
        //    get
        //    {
        //        if (_followerGRepository == null)
        //        {
        //            _followerGRepository = new GenericRepositiry<MyFollow>(db);
        //        }
        //        return _followerGRepository;
        //    }
        //}
        //public IFollowRepository FollowerRepository
        //{
        //    get
        //    {
        //        if (_followerRepository == null)
        //        {
        //            _followerRepository = new FollowRepository(db);
        //        }

        //        return _followerRepository;
        //    }
        //}

        //public GenericRepositiry<MyFollow> FollowingGRepository
        //{
        //    get
        //    {
        //        if (_followingGRepository == null)
        //        {
        //            _followingGRepository = new GenericRepositiry<MyFollow>(db);
        //        }
        //        return _followingGRepository;
        //    }
        //}
        //public IFollowRepository FollowingRepository
        //{
        //    get
        //    {
        //        if (_followingRepository == null)
        //        {
        //            _followingRepository = new FollowRepository(db);
        //        }

        //        return _followingRepository;
        //    }
        //}

        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }

    }
}
