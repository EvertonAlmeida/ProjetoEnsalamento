using Ninject.Modules;
using EA.ProjetoEnsalamento.Application;
using EA.ProjetoEnsalamento.Application.Interfaces;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly;
using EA.ProjetoEnsalamento.Domain.Interfaces.Services;
using EA.ProjetoEnsalamento.Domain.Services;
using EA.ProjetoEnsalamento.Infra.Data.Context;
using EA.ProjetoEnsalamento.Infra.Data.Interfaces;
using EA.ProjetoEnsalamento.Infra.Data.Repositories;
using EA.ProjetoEnsalamento.Infra.Data.Repositories.ReadOnly;
using EA.ProjetoEnsalamento.Infra.Data.UoW;

namespace EA.ProjetoEnsalamento.Infra.CrossCutting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            // app
            Bind<IModalidadeAppService>().To<ModalidadeAppService>();
            Bind<IUnidadeCurricularAppService>().To<UnidadeCurricularAppService>();
            Bind<ICursoAppService>().To<CursoAppService>();
           
            // service
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IModalidadeService>().To<ModalidadeService>();
            Bind<IUnidadeCurricularService>().To<UnidadeCurricularService>();
            Bind<ICursoService>().To<CursoService>();
           
            // data repos
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<,>));
            Bind<IModalidadeRepository>().To<ModalidadeRepository>();
            Bind<IUnidadeCurricularRepository>().To<UnidadeCurricularRepository>();
            Bind<ICursoRepository>().To<CursoRepository>();
           

            // data repos read only
            Bind<IModalidadeReadOnlyRepository>().To<ModalidadeReadOnlyRepository>();
            Bind<IUnidadeCurricularReadOnlyRepository>().To<UnidadeCurricularReadOnlyRepository>();
            Bind<ICursoReadOnlyRepository>().To<CursoReadOnlyRepository>();
            
            // data configs
            Bind(typeof(IContextManager<>)).To(typeof(ContextManager<>));
            Bind<IDbContext>().To<ProjetoEnsalamentoContext>();
            Bind(typeof(IUnitOfWork<>)).To(typeof(UnitOfWork<>));
        }
    }
}
