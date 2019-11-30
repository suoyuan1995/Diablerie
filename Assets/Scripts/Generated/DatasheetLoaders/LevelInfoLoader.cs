
// It's generated file. DO NOT MODIFY IT!

using Diablerie.Engine.Datasheets;
using Diablerie.Engine.IO.D2Formats;

class LevelInfoLoader : Datasheet.Loader<LevelInfo>
{

    public void LoadRecord(ref LevelInfo record, Datasheet.Stream stream)
    {
                stream.Read(ref record.name);
                stream.Read(ref record.id);
                stream.Read(ref record.pal);
                stream.Read(ref record.act);
                stream.Read(ref record.questFlag);
                stream.Read(ref record.questFlagEx);
                stream.Read(ref record.layer);
                stream.Read(ref record.sizeX);
                stream.Read(ref record.sizeY);
                stream.Read(ref record.sizeXNightmare);
                stream.Read(ref record.sizeYNightmare);
                stream.Read(ref record.sizeXHell);
                stream.Read(ref record.sizeYHell);
                stream.Read(ref record.offsetX);
                stream.Read(ref record.offsetY);
                stream.Read(ref record.depend);
                stream.Read(ref record.teleport);
                stream.Read(ref record.rain);
                stream.Read(ref record.mud);
                stream.Read(ref record.noPer);
                stream.Read(ref record.LOSDraw);
                stream.Read(ref record.floorFilter);
                stream.Read(ref record.blankScreen);
                stream.Read(ref record.drawEdges);
                stream.Read(ref record.isInside);
                stream.Read(ref record.drlgType);
                stream.Read(ref record.levelTypeIndex);
                stream.Read(ref record.subType);
                stream.Read(ref record.subTheme);
                stream.Read(ref record.subWaypoint);
                stream.Read(ref record.subShrine);
                record.vis = new int[8];
                    stream.Read(ref record.vis[0]);
                    stream.Read(ref record.vis[1]);
                    stream.Read(ref record.vis[2]);
                    stream.Read(ref record.vis[3]);
                    stream.Read(ref record.vis[4]);
                    stream.Read(ref record.vis[5]);
                    stream.Read(ref record.vis[6]);
                    stream.Read(ref record.vis[7]);
                record.warp = new int[8];
                    stream.Read(ref record.warp[0]);
                    stream.Read(ref record.warp[1]);
                    stream.Read(ref record.warp[2]);
                    stream.Read(ref record.warp[3]);
                    stream.Read(ref record.warp[4]);
                    stream.Read(ref record.warp[5]);
                    stream.Read(ref record.warp[6]);
                    stream.Read(ref record.warp[7]);
                stream.Read(ref record.intensity);
                stream.Read(ref record.red);
                stream.Read(ref record.green);
                stream.Read(ref record.blue);
                stream.Read(ref record.portal);
                stream.Read(ref record.position);
                stream.Read(ref record.saveMonsters);
                stream.Read(ref record.quest);
                stream.Read(ref record.warpDist);
                record.monLvl = new int[3];
                    stream.Read(ref record.monLvl[0]);
                    stream.Read(ref record.monLvl[1]);
                    stream.Read(ref record.monLvl[2]);
                record.monLvlEx = new int[3];
                    stream.Read(ref record.monLvlEx[0]);
                    stream.Read(ref record.monLvlEx[1]);
                    stream.Read(ref record.monLvlEx[2]);
                record.monDen = new int[3];
                    stream.Read(ref record.monDen[0]);
                    stream.Read(ref record.monDen[1]);
                    stream.Read(ref record.monDen[2]);
                stream.Read(ref record.monUMin);
                stream.Read(ref record.monUMax);
                stream.Read(ref record.monUMinNightmare);
                stream.Read(ref record.monUMaxNightmare);
                stream.Read(ref record.monUMinHell);
                stream.Read(ref record.monUMaxHell);
                stream.Read(ref record.monWndr);
                stream.Read(ref record.monSpcWalk);
                stream.Read(ref record.numMon);
                record._monsters = new string[10];
                    stream.Read(ref record._monsters[0]);
                    stream.Read(ref record._monsters[1]);
                    stream.Read(ref record._monsters[2]);
                    stream.Read(ref record._monsters[3]);
                    stream.Read(ref record._monsters[4]);
                    stream.Read(ref record._monsters[5]);
                    stream.Read(ref record._monsters[6]);
                    stream.Read(ref record._monsters[7]);
                    stream.Read(ref record._monsters[8]);
                    stream.Read(ref record._monsters[9]);
                stream.Read(ref record.rangedspawn);
                record.nMonsters = new string[10];
                    stream.Read(ref record.nMonsters[0]);
                    stream.Read(ref record.nMonsters[1]);
                    stream.Read(ref record.nMonsters[2]);
                    stream.Read(ref record.nMonsters[3]);
                    stream.Read(ref record.nMonsters[4]);
                    stream.Read(ref record.nMonsters[5]);
                    stream.Read(ref record.nMonsters[6]);
                    stream.Read(ref record.nMonsters[7]);
                    stream.Read(ref record.nMonsters[8]);
                    stream.Read(ref record.nMonsters[9]);
                record.uMonsters = new string[10];
                    stream.Read(ref record.uMonsters[0]);
                    stream.Read(ref record.uMonsters[1]);
                    stream.Read(ref record.uMonsters[2]);
                    stream.Read(ref record.uMonsters[3]);
                    stream.Read(ref record.uMonsters[4]);
                    stream.Read(ref record.uMonsters[5]);
                    stream.Read(ref record.uMonsters[6]);
                    stream.Read(ref record.uMonsters[7]);
                    stream.Read(ref record.uMonsters[8]);
                    stream.Read(ref record.uMonsters[9]);
                record.cmon = new string[4];
                    stream.Read(ref record.cmon[0]);
                    stream.Read(ref record.cmon[1]);
                    stream.Read(ref record.cmon[2]);
                    stream.Read(ref record.cmon[3]);
                record.cpct = new int[4];
                    stream.Read(ref record.cpct[0]);
                    stream.Read(ref record.cpct[1]);
                    stream.Read(ref record.cpct[2]);
                    stream.Read(ref record.cpct[3]);
                record.camt = new int[4];
                    stream.Read(ref record.camt[0]);
                    stream.Read(ref record.camt[1]);
                    stream.Read(ref record.camt[2]);
                    stream.Read(ref record.camt[3]);
                stream.Read(ref record.themes);
                stream.Read(ref record.soundEnvId);
                stream.Read(ref record.waypoint);
                stream.Read(ref record.levelName);
                stream.Read(ref record.levelWarp);
                stream.Read(ref record._entryFile);
                record.objGrp = new int[8];
                    stream.Read(ref record.objGrp[0]);
                    stream.Read(ref record.objGrp[1]);
                    stream.Read(ref record.objGrp[2]);
                    stream.Read(ref record.objGrp[3]);
                    stream.Read(ref record.objGrp[4]);
                    stream.Read(ref record.objGrp[5]);
                    stream.Read(ref record.objGrp[6]);
                    stream.Read(ref record.objGrp[7]);
                record.objPrb = new int[8];
                    stream.Read(ref record.objPrb[0]);
                    stream.Read(ref record.objPrb[1]);
                    stream.Read(ref record.objPrb[2]);
                    stream.Read(ref record.objPrb[3]);
                    stream.Read(ref record.objPrb[4]);
                    stream.Read(ref record.objPrb[5]);
                    stream.Read(ref record.objPrb[6]);
                    stream.Read(ref record.objPrb[7]);
                stream.Read(ref record.beta);
    }
}
