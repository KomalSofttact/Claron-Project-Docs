// Copyright 2013-2014 Lexmark International Technology S.A.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Claron.WIF {
  [Serializable]
  public class RegistratorEngineMultimodality : RegistratorEngine {
    /// <summary>
    /// Property to get/set modality of the first series. This property is used to determine
    /// the type of registration to do.
    /// </summary>
    public string SliceStacks0Modality {
      get;
      set;
    }
    //fujiufiuforiuioetuomj
    /// <summary>
    /// Property to get/set modality of the second series. This property is used to determine
    /// the type of registration to do.
    /// </summary>
    public string SliceStacks1Modality {
      get;
      set;
    }

    /// <summary>
    /// Stopwatch to measure time taken for registration to be done.
    /// </summary>
    [NonSerialized]
    SysUtils.WIFStopWatch _registrationTimeTakenSw;

    /// <summary>
    /// Stopwatch to measure time taken for registration to be done.
    /// </summary>
    public SysUtils.WIFStopWatch RegistrationTimeTakenSw {
      get {
        if (_registrationTimeTakenSw == null) {
          _registrationTimeTakenSw = new SysUtils.WIFStopWatch();
        }
        return _registrationTimeTakenSw;
      }
    }

    /// <summary>
    /// Does registration.
    /// </summary>
    public override void Register() {
      Log.IsActiveLogFile = true;
      this.RegistrationTimeTakenSw.Restart();
      //if (this.SliceStacks0Modality == "CT" && this.SliceStacks1Modality == "CT") {
        base.Register();
      //} else {
      //  IsRegistering = true;

      //  this.ProgressPercentageGlobalRegistration = 0;
      //  this.ProgressPercentageElasticRegistration = 0;

      //  //var p0 = this.SliceStacks0[0].Grid.PatientRcsOfFract(0.5, 0.5, 0.5);
      //  //var p1 = this.SliceStacks1[0].Grid.PatientRcsOfFract(0.5, 0.5, 0.5);
      //  var sms = new SpaceMapperSimilarity();
      //  //sms.CenterInSource = p0;
      //  //sms.CenterInTarget = p1;
      //  var cMinPr = this.SliceStacks0[0].Grid.PatientRcsOfFract(0, 0, 0);
      //  var cMaxPr = this.SliceStacks0[0].Grid.PatientRcsOfFract(1, 1, 1);


      //  this.Reg3DRigidParams.FixedImageNumberOfBins = 64;
      //  this.Reg3DRigidParams.MovingImageNumberOfBins = 64;
      //  this.Reg3DRigidParams.SimilarityMeasure = SimilarityMeasureTypeEnum.NormalizedMutualInformation;
      //  this.Reg3DRigidParams.NumberOfIterations = 5000;
      //  this.Reg3DRigidParams.OptimizationType = Registrator3DParameters.OptimizationTypeEnum.Simplex;


      //  var regSms = new Registrator3DSimilarity(this.SliceStacks0[2], this.SliceStacks1[2], sms, this.Reg3DRigidParams);
      //  regSms.DoScaling = false;
      //  regSms.Register();
      //  this.ProgressPercentageGlobalRegistration = 100;

      //  this.SpaceMapperElastic = CreateNewSpaceMapperElasticAlignedToFixedSliceStackGrid(this.SliceStacks0[2], new SpaceMapperAffine(sms), cMinPr, cMaxPr, new Vector3(100, 100, 100));

      //  this.ProgressPercentageElasticRegistration = 0;
      //  this.ProgressMessage = "Doing elastic registration.";

      //  this.Reg3DElasticParams.FixedImageNumberOfBins = 64;
      //  this.Reg3DElasticParams.MovingImageNumberOfBins = 64;
      //  this.Reg3DElasticParams.SimilarityMeasure = SimilarityMeasureTypeEnum.MutualInformation;
      //  this.Reg3DElasticParams.DistortionPenalty = 0.00000;
      //  this.Reg3DElasticParams.MaximumStepLength = 30;
      //  this.Reg3DElasticParams.NumberOfStepDivisions = 3;
      //  this.Reg3DElasticParams.NumberOfIterations = 100;
      //  this.Reg3DElasticParams.GradientEvaluationAccuracy = 25;
      //  RegisterLocal(2, 2);
      //  this.ProgressPercentageElasticRegistration = 25;

      //  this.SpaceMapperElastic = SubdivideAlignedToSliceStackGrid(this.SliceStacks0[2], this.SpaceMapperElastic);
      //  this.Reg3DElasticParams.MaximumStepLength = 15;
      //  this.Reg3DElasticParams.DistortionPenalty = 0.00001;
      //  RegisterLocal(2, 2);
      //  this.ProgressPercentageElasticRegistration = 60;

      //  this.SpaceMapperElastic = SubdivideAlignedToSliceStackGrid(this.SliceStacks0[2], this.SpaceMapperElastic);
      //  RegisterLocal(2, 2);

      //  this.ProgressPercentageElasticRegistration = 100;

      //  IsRegistering = false;
      //}
      this.RegistrationTimeTakenSw.Pause();
    }
  }
}
