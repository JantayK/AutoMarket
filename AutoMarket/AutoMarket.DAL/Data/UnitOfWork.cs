using AutoMarket.DAL.Models;
using AutoMarket.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Data
{
    /// <summary>
    /// Класс UnitOfWork с Репозиториями
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        private ApplicationDbContext _context;
        private Repository<Advert> _advertRepository;
        private Repository<Brand> _brandRepository;
        private Repository<Model> _modelRepository;
        private Repository<CarCharacteristics> _carCharacteristicsRepository;
        private Repository<Generation> _generationRepository;
        private Repository<Comment> _commentRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public Repository<Advert> AdvertRepository
        {
            get
            {
                if (_advertRepository == null)
                    _advertRepository = new Repository<Advert>(_context);
                return _advertRepository;
            }
        }
        public Repository<Brand> BrandRepository
        {
            get
            {
                if (_brandRepository == null)
                    _brandRepository = new Repository<Brand>(_context);
                return _brandRepository;
            }
        }
        public Repository<Model> ModelRepository
        {
            get
            {
                if (_modelRepository == null)
                    _modelRepository = new Repository<Model>(_context);
                return _modelRepository;
            }
        }
        public Repository<CarCharacteristics> CarCharacteristicsRepository
        {
            get
            {
                if (_carCharacteristicsRepository == null)
                    _carCharacteristicsRepository = new Repository<CarCharacteristics>(_context);
                return _carCharacteristicsRepository;
            }
        }
        public Repository<Generation> GenerationRepository
        {
            get
            {
                if (_generationRepository == null)
                    _generationRepository = new Repository<Generation>(_context);
                return _generationRepository;
            }
        }
        public Repository<Comment> CommentRepository
        {
            get
            {
                if (_commentRepository == null)
                    _commentRepository = new Repository<Comment>(_context);
                return _commentRepository;
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }  
}
