﻿namespace Autofac.Demo.Fluent.V2.Interface
{
    public interface IProvideBusinessRule
    {

        IProvideBusinessRule BuildAttributes();
        IProvideBusinessRule BoostMathsSkills();
        IProvideBusinessRule AverageOutScores();
        IProvideBusinessRule RemoveDuplicates();
        IProvideBusinessRule CombineAttributes();
        IProvideBusinessRule RemoveSupressions();
        IProvideBusinessRule MoveBottomLevelAttributes();
        IProvideBusinessRule AddTitle();
        IProvideBusinessRule GetResults();

    }
}